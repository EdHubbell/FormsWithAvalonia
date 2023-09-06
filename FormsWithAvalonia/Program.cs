using System;
using Avalonia;
using AvaloniaApplication1;
using Application = System.Windows.Forms.Application;

namespace FormsWithAvalonia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseWin32()
                .With(new Win32PlatformOptions
                {
                     
//                    UseWindowsUIComposition = false
                })
                .LogToTrace()
                .SetupWithoutStarting();

            Application.Run(new Form1());

        }
    }
}