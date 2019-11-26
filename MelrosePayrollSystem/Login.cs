using System;
using System.Configuration;
using System.Windows.Forms;

namespace MelrosePayrollSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            ConfigurationManager.AppSettings["Email"] = tbUsername.Text;

        }
    }
}
