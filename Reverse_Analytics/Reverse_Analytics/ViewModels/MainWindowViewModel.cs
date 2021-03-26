using Prism.Mvvm;

namespace Reverse_Analytics.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Trino";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public MainWindowViewModel()
        {
        }
    }
}
