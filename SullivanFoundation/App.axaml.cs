using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using SullivanFoundation.Services;
using SullivanFoundation.ViewModels;
using SullivanFoundation.ViewModels.PageViewModels;
using SullivanFoundation.Views;

namespace SullivanFoundation;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public static ServiceProvider ServiceProvider { get; private set; }

    public override void OnFrameworkInitializationCompleted()
    {
        var collection = new ServiceCollection();
        RegisterServices(collection);

        ServiceProvider = collection.BuildServiceProvider();

        // Line below is needed to remove Avalonia data validation.
        // Without this line you will get duplicate validations from both Avalonia and CT
        BindingPlugins.DataValidators.RemoveAt(0);

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = ServiceProvider.GetRequiredService<IMainViewModel>()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void RegisterServices(ServiceCollection services)
    {
        services.AddSingleton<IMainViewModel, MainViewModel>();
        services.AddSingleton<IHomePageViewModel, HomePageViewModel>();
        services.AddSingleton<IAccountsPageViewModel, AccountsPageViewModel>();
        services.AddSingleton<IReportsPageViewModel, ReportsPageViewModel>();
        services.AddSingleton<ISettingsPageViewModel, SettingsPageViewModel>();
        services.AddSingleton<IAccountsService, AccountsService>();
    }
}
