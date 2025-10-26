namespace Client
{
    partial class frmMain
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
            lblName = new Label();
            lblEmail = new Label();
            lblBirth = new Label();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 53);
            label1.Name = "label1";
            label1.Size = new Size(207, 59);
            label1.TabIndex = 0;
            label1.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 154);
            label2.Name = "label2";
            label2.Size = new Size(76, 45);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 242);
            label3.Name = "label3";
            label3.Size = new Size(103, 45);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 330);
            label4.Name = "label4";
            label4.Size = new Size(143, 45);
            label4.TabIndex = 3;
            label4.Text = "Birthday:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(349, 154);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 45);
            lblName.TabIndex = 4;
            lblName.Text = "label5";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(349, 242);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 45);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "label6";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirth.Location = new Point(349, 330);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(105, 45);
            lblBirth.TabIndex = 6;
            lblBirth.Text = "label7";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(586, 474);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 46);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 589);
            Controls.Add(btnLogOut);
            Controls.Add(lblBirth);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "frmMain";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblEmail;
        private Label lblBirth;
        private Button btnLogOut;
    }
}