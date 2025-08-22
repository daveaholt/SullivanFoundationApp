using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SullivanFoundation.ViewModels.PageViewModels
{
    public interface IHomePageViewModel
    {
        string Title { get; set; }
    }
    public class HomePageViewModel : ViewModelBase, IHomePageViewModel
    {
        public HomePageViewModel()
        {
            _title = "Welcome to the Home page.";
        }

        private string _title;
        public string Title { get => _title; set => Set(ref _title, value); }
    }
}
