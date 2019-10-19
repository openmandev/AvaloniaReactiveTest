using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.Controls.ApplicationLifetimes;
using AvaloniaReactiveTest.ViewModels;
using AvaloniaReactiveTest.Views;

namespace AvaloniaReactiveTest
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
 
        public override void OnFrameworkInitializationCompleted()
        {
            if ( ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop )
            {
                desktop.MainWindow = new MainWindow();
                desktop.MainWindow.DataContext = new MainWindowViewModel();
            }
            base.OnFrameworkInitializationCompleted();
        }
  }
}