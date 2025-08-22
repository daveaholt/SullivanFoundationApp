using CommunityToolkit.Mvvm.Input;
using SullivanFoundation.Models;
using SullivanFoundation.Services;
using System.Collections.Generic;
using System.Windows.Input;

namespace SullivanFoundation.ViewModels.PageViewModels
{
    public interface IAccountsPageViewModel
    {
        string Title { get; set; }
        List<Account> Accounts {get;set; }
        ICommand PageLoadedCommand { get; }
    }
    public class AccountsPageViewModel : ViewModelBase, IAccountsPageViewModel
    {
        private readonly IAccountsService _accountsService;
        public AccountsPageViewModel(IAccountsService accountsService)
        {
            _title = "Welcome to the Accounts page.";
            _accountsService = accountsService;
        }

        private string _title;
        public string Title { get => _title; set => Set(ref _title, value); }


        private List<Account> _accounts = new();
        public List<Account> Accounts { get => _accounts; set => Set(ref _accounts, value); }

        public ICommand PageLoadedCommand => new RelayCommand(OnPageLoaded);

        private void OnPageLoaded()
        {
            Accounts.Clear();
            Accounts = _accountsService.GetAccounts();
        }
    }
}
