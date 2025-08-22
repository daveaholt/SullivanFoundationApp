using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SullivanFoundation.ViewModels.PageViewModels
{
    public interface ISettingsPageViewModel
    {
        string Title { get; }
    }

    public class SettingsPageViewModel : ViewModelBase, ISettingsPageViewModel
    {
        public SettingsPageViewModel()
        {
            _title = "Welcome to the Settings page.";
        }
        
        private string _title;
        public string Title { get => _title; set => Set(ref _title, value); }
    }
}
