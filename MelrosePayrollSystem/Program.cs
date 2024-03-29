﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelrosePayrollSystem
{
    static class Program
    {        
        internal static FormManager formManager = new FormManager();        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (new Login().ShowDialog() == DialogResult.OK)
            {
                Application.Run(Program.formManager.OpenForm("Menu"));
            }
        }
    }
}
