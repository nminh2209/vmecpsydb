using System;
using System.Windows.Forms;

namespace EESSP
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

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                Application.Run(new MainForm(loginForm.ConnectedUser));
            }
        }
    }
}
