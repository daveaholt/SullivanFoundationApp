using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SullivanFoundation.ViewModels.PageViewModels
{
    public interface IReportsPageViewModel
    {
        string Title { get; set; }
    }

    public class ReportsPageViewModel : ViewModelBase, IReportsPageViewModel
    {
        public ReportsPageViewModel()
        {
            _title = "Welcome to the Reports page.";
        }

        private string _title;
        public string Title { get => _title; set => Set(ref _title, value); }
    }
}
