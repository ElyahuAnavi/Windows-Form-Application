namespace Pass_Data_Between_Forms
{
    partial class SignUpForm
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
            LblFirstName = new Label();
            TextFirstName = new TextBox();
            LblLastName = new Label();
            TextLastName = new TextBox();
            LblEmail = new Label();
            TextEmail = new TextBox();
            groupBox1 = new GroupBox();
            LblTransactionsReportsMessage = new Label();
            LblSmsMessage = new Label();
            ChkTransactionsReports = new CheckBox();
            ChkReports = new CheckBox();
            ChkSmsNotifications = new CheckBox();
            BtnSignUp = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LblFirstName
            // 
            LblFirstName.AutoSize = true;
            LblFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFirstName.Location = new Point(302, 74);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(116, 25);
            LblFirstName.TabIndex = 0;
            LblFirstName.Text = "First Name";
            // 
            // TextFirstName
            // 
            TextFirstName.Location = new Point(490, 78);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(313, 27);
            TextFirstName.TabIndex = 1;
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblLastName.Location = new Point(302, 126);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(115, 25);
            LblLastName.TabIndex = 0;
            LblLastName.Text = "Last Name";
            // 
            // TextLastName
            // 
            TextLastName.Location = new Point(490, 130);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(313, 27);
            TextLastName.TabIndex = 1;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmail.Location = new Point(302, 180);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(65, 25);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email";
            // 
            // TextEmail
            // 
            TextEmail.Location = new Point(490, 184);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(313, 27);
            TextEmail.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblTransactionsReportsMessage);
            groupBox1.Controls.Add(LblSmsMessage);
            groupBox1.Controls.Add(ChkTransactionsReports);
            groupBox1.Controls.Add(ChkReports);
            groupBox1.Controls.Add(ChkSmsNotifications);
            groupBox1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(123, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 213);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services";
            // 
            // LblTransactionsReportsMessage
            // 
            LblTransactionsReportsMessage.AutoSize = true;
            LblTransactionsReportsMessage.ForeColor = Color.FromArgb(255, 128, 0);
            LblTransactionsReportsMessage.Location = new Point(401, 166);
            LblTransactionsReportsMessage.Name = "LblTransactionsReportsMessage";
            LblTransactionsReportsMessage.RightToLeft = RightToLeft.Yes;
            LblTransactionsReportsMessage.Size = new Size(62, 28);
            LblTransactionsReportsMessage.TabIndex = 1;
            LblTransactionsReportsMessage.Text = "..........";
            // 
            // LblSmsMessage
            // 
            LblSmsMessage.AutoSize = true;
            LblSmsMessage.ForeColor = Color.FromArgb(255, 128, 0);
            LblSmsMessage.Location = new Point(401, 55);
            LblSmsMessage.Name = "LblSmsMessage";
            LblSmsMessage.RightToLeft = RightToLeft.Yes;
            LblSmsMessage.Size = new Size(62, 28);
            LblSmsMessage.TabIndex = 1;
            LblSmsMessage.Text = "..........";
            // 
            // ChkTransactionsReports
            // 
            ChkTransactionsReports.AutoSize = true;
            ChkTransactionsReports.Location = new Point(138, 162);
            ChkTransactionsReports.Name = "ChkTransactionsReports";
            ChkTransactionsReports.Size = new Size(229, 32);
            ChkTransactionsReports.TabIndex = 0;
            ChkTransactionsReports.Text = "TransactionsReports";
            ChkTransactionsReports.UseVisualStyleBackColor = true;
            ChkTransactionsReports.CheckedChanged += ChkTransactionsReports_CheckedChanged;
            // 
            // ChkReports
            // 
            ChkReports.AutoSize = true;
            ChkReports.Location = new Point(138, 106);
            ChkReports.Name = "ChkReports";
            ChkReports.Size = new Size(109, 32);
            ChkReports.TabIndex = 0;
            ChkReports.Text = "Reports";
            ChkReports.UseVisualStyleBackColor = true;
            ChkReports.CheckedChanged += ChkReports_CheckedChanged;
            // 
            // ChkSmsNotifications
            // 
            ChkSmsNotifications.AutoSize = true;
            ChkSmsNotifications.Location = new Point(138, 51);
            ChkSmsNotifications.Name = "ChkSmsNotifications";
            ChkSmsNotifications.Size = new Size(208, 32);
            ChkSmsNotifications.TabIndex = 0;
            ChkSmsNotifications.Text = "SMS Notifications";
            ChkSmsNotifications.UseVisualStyleBackColor = true;
            ChkSmsNotifications.CheckedChanged += ChkSmsNotifications_CheckedChanged;
            // 
            // BtnSignUp
            // 
            BtnSignUp.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnSignUp.Location = new Point(430, 556);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(252, 50);
            BtnSignUp.TabIndex = 3;
            BtnSignUp.Text = "Sign Up";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 635);
            Controls.Add(BtnSignUp);
            Controls.Add(groupBox1);
            Controls.Add(TextEmail);
            Controls.Add(LblEmail);
            Controls.Add(TextLastName);
            Controls.Add(LblLastName);
            Controls.Add(TextFirstName);
            Controls.Add(LblFirstName);
            Name = "SignUpForm";
            Text = "SignUpForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFirstName;
        private TextBox TextFirstName;
        private Label LblLastName;
        private TextBox TextLastName;
        private Label LblEmail;
        private TextBox TextEmail;
        private GroupBox groupBox1;
        private CheckBox ChkTransactionsReports;
        private CheckBox ChkReports;
        private CheckBox ChkSmsNotifications;
        private Label LblTransactionsReportsMessage;
        private Label LblSmsMessage;
        private Button BtnSignUp;
    }
}