namespace Client
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            txtEmail = new TextBox();
            txtFullname = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            dtBirthday = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 61);
            label1.Name = "label1";
            label1.Size = new Size(169, 59);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 147);
            label2.Name = "label2";
            label2.Size = new Size(170, 45);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(170, 230);
            label3.Name = "label3";
            label3.Size = new Size(160, 45);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 318);
            label4.Name = "label4";
            label4.Size = new Size(265, 45);
            label4.TabIndex = 3;
            label4.Text = "Cofirm Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 398);
            label5.Name = "label5";
            label5.Size = new Size(103, 45);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(170, 485);
            label6.Name = "label6";
            label6.Size = new Size(171, 45);
            label6.TabIndex = 5;
            label6.Text = "Full Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(170, 576);
            label7.Name = "label7";
            label7.Size = new Size(143, 45);
            label7.TabIndex = 6;
            label7.Text = "Birthday:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(442, 154);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(439, 39);
            txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(442, 237);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(439, 39);
            txtPass.TabIndex = 8;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(441, 325);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(440, 39);
            txtConfirm.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(442, 404);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(439, 39);
            txtEmail.TabIndex = 10;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(442, 491);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(439, 39);
            txtFullname.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(384, 705);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 46);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(731, 705);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtBirthday
            // 
            dtBirthday.CustomFormat = "dd/MM/yyyy";
            dtBirthday.Location = new Point(441, 582);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(440, 39);
            dtBirthday.TabIndex = 15;
            dtBirthday.Value = new DateTime(2025, 10, 26, 0, 0, 0, 0);
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 838);
            Controls.Add(dtBirthday);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private TextBox txtEmail;
        private TextBox txtFullname;
        private Button btnRegister;
        private Button btnCancel;
        private DateTimePicker dtBirthday;
    }
}