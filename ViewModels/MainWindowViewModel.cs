namespace AvaloniaUIComponents.ViewModels
{
    using System.Threading;
    using System.Threading.Tasks;
    using ReactiveUI.SourceGenerators;

    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";

        [ReactiveCommand]
        private async Task OnButtonClickAsync()
        {
            await Task.Delay(2000);
        }
    }
}
