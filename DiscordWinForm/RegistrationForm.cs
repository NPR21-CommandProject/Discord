using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordWinForm.Entities;
using DiscordWinForm.Helpers;
using DiscordWinForm.StartupManagers.DatabaseManagers;

namespace DiscordWinForm
{


    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != string.Empty && txtNickname.Text != string.Empty &&
                txtPassword.Text != string.Empty && txtPictureURL.Text != string.Empty)
            {
                UserDbHelper.AddUser(txtUsername.Text, txtNickname.Text, txtPassword.Text, txtPictureURL.Text, "127.0.0.1");
                FormManager.RunForm(new AuthorizationForm(), this);
            }
            else MessageBox.Show("Some field is empty!");
        }
    }
}
