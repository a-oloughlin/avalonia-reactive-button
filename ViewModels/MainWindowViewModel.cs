namespace AvaloniaUIComponents.ViewModels
{
    using System.Threading;
    using ReactiveUI.SourceGenerators;

    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";

        [ReactiveCommand]
        private void OnButtonClick()
        {
            Thread.Sleep(2000); 
        }
    }
}
