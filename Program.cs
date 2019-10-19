using System;
using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.Logging.Serilog;
using AvaloniaReactiveTest.ViewModels;
using AvaloniaReactiveTest.Views;

namespace AvaloniaReactiveTest
{
    class Program
    {
        public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect().UseReactiveUI();

        public static int Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }
}
