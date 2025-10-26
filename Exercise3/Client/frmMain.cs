using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmMain : Form
    {
        private string username;
        private string token;
        public frmMain(string username, string token)
        {
            InitializeComponent();
            this.username = username;
            this.token = token;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                string mes = $"GETINFO|{token}";
                TcpClient client = new TcpClient("127.0.0.1", 8000);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(mes);
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[1024];
                int bytes = stream.Read(buffer, 0, buffer.Length);

                client.Close();

                string response = Encoding.UTF8.GetString(buffer, 0, bytes);

                if (response.StartsWith("USERINFO"))
                {
                    string[] info = response.Split('|');
                    lblName.Text = info[1];
                    lblEmail.Text = info[2];
                    lblBirth.Text = Convert.ToDateTime(info[3]).ToString("dd/MM/yyyy");

                }
                else if (response == "INVALID_TOKEN")
                {
                    MessageBox.Show("Token không hợp lệ, vui lòng đăng nhập lại!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin người dùng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin: " + ex.Message);
            }
        }

        private bool isLoggingOut = false;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            MessageBox.Show("Đã đăng xuất!");
            new frmLogin().Show();
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
                Application.Exit();
        }
    }
}
