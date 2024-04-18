using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pass_Data_Between_Forms
{
    public partial class SignUpForm : Form
    {
        public string fName;
        public string lName;
        public string emailAddress;
        public bool sms;
        public bool reports;
        public bool transactions;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            fName = TextFirstName.Text;
            lName = TextLastName.Text;
            emailAddress = TextEmail.Text;
        }

        private void ChkSmsNotifications_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSmsNotifications.Checked)
            {
                sms = true;
                LblSmsMessage.Text = "Services Charges may Apply For SMS.";
            }
            else
            {
                sms = false;
                LblSmsMessage.Text = ".......";
            }
        }

        private void ChkReports_CheckedChanged(object sender, EventArgs e)
        {
            reports = ChkReports.Checked;
        }

        private void ChkTransactionsReports_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTransactionsReports.Checked)
            {
                transactions = true;
                LblTransactionsReportsMessage.Text = "Services Charges may Apply for Transaction.";
            }
            else
            {
                transactions = false;
                LblTransactionsReportsMessage.Text = ".......";
            }
        }
    }
}
