using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWinForm.Helpers
{
    public static class FormHelper
    {
        /// <summary>
        /// Make new thread for formToRun and then close the formToClose in previous thread
        /// </summary>
        public static void RunForm(Form formToRun, Form formToClose = null)
        {
            Thread t = new Thread(() => formToRun.ShowDialog());
            t.Start();
            formToClose?.Close();
        }
    }
}
