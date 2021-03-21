using Prism.Commands;
using Prism.Regions;
using Reverse_Analytics.Core;
using Reverse_Analytics.Core.MVVM;
using Reverse_Analytics.Core.Resources;
using System.Linq;

namespace Reverse.Modules.ModuleNames.ViewModels
{
    public class NavigationViewModel : RegionViewModelBase
    {
        #region Commands

        public DelegateCommand<string> NavigateCommand { get; set; }
        public DelegateCommand LogoutCommand { get; set; }

        #endregion

        #region Form properties

        private string _navigationText;
        public string NavigationText 
        {
            get => _navigationText;
            set => SetProperty(ref _navigationText, value);
        }

        private string _login;
        private string Login
        { 
            get => _login;
            set => SetProperty(ref _login, value);    
        }

        #endregion

        public NavigationViewModel(IRegionManager regionManager) : base(regionManager)
        {
            NavigationText = "Navigation...";
            NavigateCommand = new DelegateCommand<string>(Navigate);
            LogoutCommand = new DelegateCommand(Logout);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey(nameof(Login)))
                Login = $"{Strings.User}: {navigationContext.Parameters.GetValue<string>(nameof(Login))}";
        }

        private void Logout()
        {
            ClearAllRegions();

            RegionManager.RequestNavigate(RegionNames.ContentRegion, ViewNames.LoginView);
        }

        private void ClearAllRegions() =>
            RegionManager.Regions.ToList().ForEach(region => region.RemoveAll());

        private void Navigate(string uri) => 
            RegionManager.RequestNavigate(RegionNames.ContentRegion, uri);
    }
}
