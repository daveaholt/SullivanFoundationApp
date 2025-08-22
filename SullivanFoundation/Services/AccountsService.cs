using SullivanFoundation.Models;
using System.Collections.Generic;

namespace SullivanFoundation.Services
{
    public interface IAccountsService
    {
        List<Account> GetAccounts();
    }
    public class AccountsService : IAccountsService
    {
        public List<Account> GetAccounts()
        {
            return new List<Account> { };
        }
    }
}
