using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            string email = txtEmail.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string birthday = dtBirthday.Value.ToString("yyyy-MM-dd");

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string hashed = HashPass(password);

            string message = $"REGISTER|{username}|{hashed}|{email}|{fullname}|{birthday}";
            string response = SendToServer(message);

            if (response == "REGISTER_SUCCESS")
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Tên đăng nhập có thể đã tồn tại.");
            }
        }
        private string HashPass(string pass)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return Convert.ToHexString(hash);
            }
        }

        private string SendToServer(string mes)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối server: " + ex.Message);
                return "ERROR";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            string pattern = @"^[a-zA-Z0-9.&%+_/-]+@[a-z]+\.[a-z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
