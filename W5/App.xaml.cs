using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using W5.ViewModels;

namespace W5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                 new ServiceCollection()
                 .AddSingleton<MainWindowViewModel>()
                 .AddSingleton<IMessenger>(WeakReferenceMessenger.Default)
                 .BuildServiceProvider()
                 );
        }
    }
}
