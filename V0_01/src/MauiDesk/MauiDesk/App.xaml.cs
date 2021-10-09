#nullable enable
using Microsoft.UI.Xaml;
#pragma warning disable CA1416

namespace MauiDesk
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            _mainWindow = new MainWindow();
            _mainWindow.Title = "Maui Desk";
            _mainWindow.Activate();
        }

        private Window? _mainWindow;
    }
}
