using System;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaReactiveTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ButtonCommand = ReactiveCommand.Create(TestClick);
        }

        private void TestClick()
        {
            Console.WriteLine("TestClick.");
        }

        public string ButtonText => "Click me!";

        public ReactiveCommand<Unit, Unit> ButtonCommand { get; }
    }
}
