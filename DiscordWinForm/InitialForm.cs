using DiscordWinForm;
using DiscordWinForm.Helpers;

namespace DiscordWinForm
{




    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormHelper.RunForm(new AuthorizationForm(), this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormHelper.RunForm(new RegistrationForm(), this);
        }
    }
}
