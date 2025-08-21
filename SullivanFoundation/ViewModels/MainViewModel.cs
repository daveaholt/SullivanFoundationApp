namespace SullivanFoundation.ViewModels;

public class MainViewModel : ViewModelBase, IMainViewModel
{
    public MainViewModel()
    {
        _greeting = "Good morning, Dave.";
    }

    private string _greeting;
    public string Greeting
    {
        get => _greeting;
        set => Set(ref _greeting, value);
    }
}
