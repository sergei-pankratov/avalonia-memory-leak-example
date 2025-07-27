
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using Avalonia.Animation;

namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            int counter = 0;
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    counter++;
                    Greeting = counter.ToString();
                    await Task.Delay(1);
                    OnPropertyChanged(nameof(Greeting));
                }
            });

        }
        public string Greeting { get; private set; } = "Welcome to Avalonia!";

    }
}
