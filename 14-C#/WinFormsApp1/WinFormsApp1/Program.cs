namespace WinFormsApp1
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
            //Application.Run(new helloGDI());
            //Application.Run(new MovingBall());
            //Application.Run(new paint());
            //Application.Run(new Drag_Drop());
            Application.Run(new micky());
        }
    }
}