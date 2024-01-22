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

namespace DiscordWinForm
{
    public partial class AuthorizationForm : Form
    {
        private UserHelper UserHelper;

        public AuthorizationForm()
        {
            UserHelper = new UserHelper();
            InitializeComponent();
        }

        public AuthorizationForm(UserAuthorizationHelper uah)
        {
            UserHelper = new UserHelper();
            InitializeComponent();
            txtUsername.Text = uah.Username;
            txtPassword.Text = uah.Password;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                User user = UserHelper.GetUser(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    if (chkRememberMe.Checked)
                    {
                        UserAuthorizationHelper af = new UserAuthorizationHelper(txtUsername.Text, txtPassword.Text);
                        af.Serialize();
                    }

                    //допиши сюда передачу user в основну форму


                }
                else MessageBox.Show("There is no such user");
            }
            else MessageBox.Show("You haven't entered username or password");
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
