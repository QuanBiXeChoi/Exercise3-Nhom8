using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string HashPass(string pass)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return Convert.ToHexString(hash);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = HashPass(txtPass.Text);

            string mes = $"LOGIN|{user}|{pass}";
            string response = SendToServer(mes);

            if (response.StartsWith("LOGIN_SUCCESS"))
            {
                string token = response.Split('|')[1];
                frmMain main = new frmMain(user, token);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().ShowDialog();
        }

        private string SendToServer(string mes)
        {
            TcpClient client = new TcpClient("127.0.0.1", 8000);
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(mes);
            stream.Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            client.Close();

            return Encoding.UTF8.GetString(buffer, 0, bytes);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
