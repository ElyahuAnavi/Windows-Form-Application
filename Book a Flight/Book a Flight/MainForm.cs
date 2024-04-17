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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World Again and Again";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Text has been cancelled...";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

    }
}
