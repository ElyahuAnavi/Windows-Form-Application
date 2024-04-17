namespace Book_a_Flight
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true) 
            {
                LoginForm loginForm = new LoginForm();
                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    Application.Run(mainForm); 
                }
                else
                {
                    break;
                }
            }
        }

    }
}