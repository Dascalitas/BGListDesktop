namespace BGListDesktop
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            Application.Run(new MainPageForm(new Guid("4093E20F-0B96-4570-8331-513AF824BCF5")));
        }
    }
}