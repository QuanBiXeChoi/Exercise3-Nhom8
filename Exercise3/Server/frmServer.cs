using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using Azure;

namespace Server
{
    public partial class frmServer : Form
    {
        TcpListener server;
        bool isRunning = false;
        SqlConnection conn;
        string connection = @"Data Source=.;Initial Catalog=Exercise3;Integrated Security=True;TrustServerCertificate = True";
        public frmServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }
        private void StartServer() 
        {
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                server = new TcpListener(IPAddress.Any, 8000);
                server.Start();
                isRunning = true;
                Log("Server đang chạy trên cổng 8000");

                while (isRunning)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Log("Client mới kết nối");
                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (Exception ex) 
            {
                Log("Lỗi: " + ex.Message);
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string[] parts = message.Split('|');

                    string command = parts[0];
                    string response = "";

                    if (command == "REGISTER")
                    {
                        bool ok = RegisterUser(parts[1], parts[2], parts[3], parts[4], parts[5]);
                        response = ok ? "REGISTER_SUCCESS" : "REGISTER_FAILED";
                    }
                    else if (command == "LOGIN")
                    {
                        string token = LoginUser(parts[1], parts[2]);
                        response = token != null ? "LOGIN_SUCCESS|" + token : "LOGIN_FAIL";
                    }
                    else if (command == "GETINFO")
                    {
                        string username = ValidateToken(parts[1]);
                        response = username != null ? GetUserInfo(username) : "INVALID_TOKEN";
                    }

                    byte[] sendData = Encoding.UTF8.GetBytes(response);
                    stream.Write(sendData, 0, sendData.Length);
                }
            }
            catch (Exception ex)
            {
                Log("Lỗi client: " + ex.Message);
            }
        }

        private bool RegisterUser(string username, string password, string email, string fullname, string birthday)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", username);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) return false;

                string insertQuery = "INSERT INTO Users (Username, Passwd, Email, FullName, Birthday) VALUES (@u,@p,@e,@f,@b)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@f", fullname);
                cmd.Parameters.AddWithValue("@b", birthday);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string? LoginUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Passwd=@p";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);
            int valid = (int)cmd.ExecuteScalar();
            if (valid == 1)
            {
                string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                TokenStorage.AddToken(token, username);
                return token;
            }
            return null;
        }

        private string ValidateToken(string token)
        {
            return TokenStorage.Validate(token);
        }

        private string GetUserInfo(string username)
        {
            string query = "SELECT FullName, Email, Birthday FROM Users WHERE Username=@u";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string info = $"{reader["FullName"]}|{reader["Email"]}|{reader["Birthday"]}";
                reader.Close();
                return "USERINFO|" + info;
            }
            reader.Close();
            return "NOT_FOUND";
        }

        public static class TokenStorage
        {
            private static Dictionary<string, string> tokens = new Dictionary<string, string>();

            public static void AddToken(string token, string username)
            {
                tokens[token] = username;
            }

            public static string? Validate(string token)
            {
                return tokens.TryGetValue(token, out string? value) ? value : null;
            }
        }
        private void Log(string msg)
        {
            Invoke(new Action(() => txtLog.AppendText(msg + Environment.NewLine)));
        }
    }
}
