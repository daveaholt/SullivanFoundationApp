
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using SullivanFoundation.ViewModels.PageViewModels;
using System.Windows.Input;

namespace SullivanFoundation.ViewModels;

public interface IMainViewModel
{
    string Greeting{ get; set; }
    ViewModelBase CurrentPage { get; set; }
    ICommand GoToHomeCommand { get; }
    ICommand GoToAccountsCommand { get; }
    ICommand GoToReportsCommand { get; }
    ICommand GoToSettingsCommand { get; }
}

public class MainViewModel : ViewModelBase, IMainViewModel
{
    public MainViewModel()
    {
        _greeting = "Good morning, Dave.";
        _currentPage = (ViewModelBase)App.ServiceProvider.GetRequiredService<IHomePageViewModel>();
    }

    private string _greeting;
    public string Greeting
    {
        get => _greeting;
        set => Set(ref _greeting, value);
    }

    private ViewModelBase _currentPage;
    public ViewModelBase CurrentPage
    {
        get => _currentPage;
        set => Set(ref _currentPage, value);
    }

    public ICommand GoToHomeCommand => new RelayCommand(GoToHome);

    public ICommand GoToAccountsCommand => new RelayCommand(GoToAccounts);

    public ICommand GoToReportsCommand => new RelayCommand(GoToReports);

    public ICommand GoToSettingsCommand => new RelayCommand(GoToSettings);


    private void GoToHome()
    {
        CurrentPage = (ViewModelBase)App.ServiceProvider.GetRequiredService<IHomePageViewModel>();
    }

    private void GoToAccounts()
    {
        CurrentPage = (ViewModelBase)App.ServiceProvider.GetRequiredService<IAccountsPageViewModel>();
    }

    private void GoToReports()
    {
        CurrentPage = (ViewModelBase)App.ServiceProvider.GetRequiredService<IReportsPageViewModel>();
    }

    private void GoToSettings()
    {
        CurrentPage = (ViewModelBase)App.ServiceProvider.GetRequiredService<ISettingsPageViewModel>();
    }
}
