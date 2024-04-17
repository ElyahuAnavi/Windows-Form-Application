using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_a_Flight
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            if (userName.Equals("!25") && password.Equals("123456"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password or UserName is incorrect...");
            }
        }

        private void ResetForm()
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textPassword_Key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetForm();
            }
        }
    }
}
