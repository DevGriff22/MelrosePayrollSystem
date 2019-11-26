using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelrosePayrollSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Program.formManager.OpenForm("Employee").ShowDialog();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            Program.formManager.OpenForm("HR").ShowDialog();
        }
    }
}
