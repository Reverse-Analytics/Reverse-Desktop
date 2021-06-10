using Prism.Commands;
using Prism.Regions;
using Reverse.Services.Interfaces;
using Reverse_Analytics.Core;
using Reverse_Analytics.Core.MVVM;
using System.Windows;
using System.Windows.Input;

namespace Reverse.Modules.ModuleNames.ViewModels
{
    public class LoginViewModel : RegionViewModelBase
    {
        #region Commands

        public DelegateCommand LoginCommand { get; set; }

        #endregion

        #region Form properties

        private string _login = "admin";
        public string Login 
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password = "admin";
        public string Password 
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _errorMessage;
        public string ErrorMessage 
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set => SetProperty(ref _welcomeMessage, value);
        }

        private Visibility _visibleError = Visibility.Hidden;
        public Visibility VisibleError
        {
            get => _visibleError;
            set => SetProperty(ref _visibleError, value);
        }

        #endregion

        public LoginViewModel(IRegionManager regionManager, IMessageService messageService) : base(regionManager)
        {
            WelcomeMessage = messageService.GetWelcomeMessage();
            ErrorMessage = messageService.GetLoginErrorMessage();

            LoginCommand = new DelegateCommand(LoginUser, CanLogin);
        }

        private bool CanLogin()
        {
            VisibleError = Visibility.Hidden;

            return !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);
        }

        private void LoginUser()
        {
            // Check user
            if (Login != "admin" || Password != "admin")
            {
                VisibleError = Visibility.Visible;
                return;
            }

            //Add login to parameters
            var parameters = new NavigationParameters
            {
                { nameof(Login), Login }
            };

            RegionManager.RequestNavigate(RegionNames.NavigationRegion, ViewNames.NavigationView, parameters);
            RegionManager.RequestNavigate(RegionNames.SideBarRegion, ViewNames.SidebarView);
            RegionManager.RequestNavigate(RegionNames.ActionRegion, ViewNames.ActionView);
        }

        
    }
}
