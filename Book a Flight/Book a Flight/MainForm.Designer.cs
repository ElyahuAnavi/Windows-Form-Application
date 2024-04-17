namespace Book_a_Flight
{
    partial class MainForm
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
            btnSet = new Button();
            lblGreeting = new Label();
            btnCancel = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnSet
            // 
            btnSet.BackColor = SystemColors.ControlLight;
            btnSet.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnSet.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSet.Location = new Point(77, 375);
            btnSet.Name = "btnSet";
            btnSet.Padding = new Padding(5);
            btnSet.Size = new Size(167, 60);
            btnSet.TabIndex = 0;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = false;
            btnSet.Click += btnSet_Click;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Simple Indust Shaded", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreeting.Location = new Point(76, 59);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(204, 44);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Hello World";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCancel.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(265, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(167, 60);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlLight;
            btnLogout.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnLogout.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(599, 375);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5);
            btnLogout.Size = new Size(167, 60);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 469);
            Controls.Add(lblGreeting);
            Controls.Add(btnLogout);
            Controls.Add(btnCancel);
            Controls.Add(btnSet);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSet;
        private Label lblGreeting;
        private Button btnCancel;
        private Button btnLogout;
    }
}