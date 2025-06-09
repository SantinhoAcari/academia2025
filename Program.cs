using DotNetEnv;

namespace Academia2025
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string? appPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (appPath == null)
            {
                throw new InvalidOperationException("Application path could not be determined.");
            }

            string envPath = Path.Combine(appPath, ".env");

            if (File.Exists(envPath))
            {
                Env.Load(envPath);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}