using DiscordWinForm.Helpers;

namespace DiscordWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            UserAuthorizationHelper uah = new UserAuthorizationHelper();
            if(uah.Deserialize()) {
                Application.Run(new AuthorizationForm(uah));
            }
            else
            {
                // see https://aka.ms/applicationconfiguration.
                Application.Run(new InitialForm());
            }
        }
    }
}