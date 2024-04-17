namespace Book_a_Flight
{
    partial class LoginForm
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
            lblUserName = new Label();
            tbUserName = new TextBox();
            lblPassword = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(223, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 27);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(398, 84);
            tbUserName.Margin = new Padding(3, 2, 3, 2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(276, 26);
            tbUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(223, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 27);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(398, 142);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(276, 26);
            tbPassword.TabIndex = 1;
            tbPassword.KeyPress += textPassword_Key;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Constantia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(342, 218);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 60);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(361, 327);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 39);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 406);
            Controls.Add(lblUserName);
            Controls.Add(tbUserName);
            Controls.Add(lblPassword);
            Controls.Add(tbPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnReset);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox tbUserName;
        private Label lblPassword;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnReset;
    }
}