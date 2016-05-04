﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Application = System.Windows.Application;

namespace GandalfSax
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 0 || e.Args[0].ToLower().StartsWith("/s"))
            {
                foreach (Screen s in Screen.AllScreens)
                {
                    Window window = null;
                    if (s.Primary)
                        window = new MainWindow();
                    else
                        window = new MuteWindow();

                    window.Left   = s.WorkingArea.Left;
                    window.Top    = s.WorkingArea.Top;
                    window.Show();
                    window.WindowState = WindowState.Maximized;
                }
            }
            else if (e.Args[0].ToLower().StartsWith("/p")) // preview screensaver
            {
            }
            else if (e.Args[0].ToLower().StartsWith("/c")) // configure screensaver
            {
            }
        }
    }
}
