using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordWinForm.Entities;
using DiscordWinForm.Helpers;
using DiscordWinForm.StartupManagers;
using DiscordWinForm.StartupManagers.DatabaseManagers;
using WinFormsApp1;

namespace DiscordWinForm
{
    public partial class AuthorizationForm : Form
    {
        private UserDbHelper UserHelper;

        public AuthorizationForm()
        {
            UserHelper = new UserDbHelper();
            InitializeComponent();
        }

        public AuthorizationForm(AuthorizationManager uah)
        {
            UserHelper = new UserDbHelper();
            InitializeComponent();
            txtUsername.Text = uah.Username;
            txtPassword.Text = uah.Password;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                UserHelper.InitUser(txtUsername.Text, txtPassword.Text);
                UserDbHelper.GetFriends();
                if (chkRememberMe.Checked)
                {
                    AuthorizationManager af = new AuthorizationManager(txtUsername.Text, txtPassword.Text);
                    af.Serialize();
                }

                FormManager.RunForm(new ChatForm(), this);
            }
            else MessageBox.Show("You haven't entered username or password");
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
