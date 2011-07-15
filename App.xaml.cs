﻿namespace e2Kindle
{
    using System.Windows;
    using NLog.Config;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            ConfigurationItemFactory.Default.Targets.RegisterDefinition("MyTarget", typeof(NLogTarget));
        }
    }
}
