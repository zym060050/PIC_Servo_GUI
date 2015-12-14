using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Motor_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //*--- Programmer's Form ---//
            Application.Run(new Form1());
            //*--- User's Form ---//
 //           Application.Run(new Form2());
            EndBox();
        }

        private static void EndBox()
        {
            //MessageBox.Show("The Comnunication is disconnected!", "My Application",
            //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

    }
}
