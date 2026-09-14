namespace StudentProfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClick = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblLogin = new Label();
            txtUsername = new TextBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClick.Location = new Point(95, 284);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(128, 44);
            btnClick.TabIndex = 0;
            btnClick.Text = "Log In";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(23, 72);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(127, 31);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(21, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 31);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(26, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 38);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(95, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(118, 41);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "LOG IN";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(26, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 38);
            txtUsername.TabIndex = 6;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Crimson;
            lblMessage.Location = new Point(26, 248);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 23);
            lblMessage.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 353);
            Controls.Add(lblMessage);
            Controls.Add(txtUsername);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnClick);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox txtPassword;
        private Label lblLogin;
        private TextBox txtUsername;
        private Label lblMessage;
    }
}
