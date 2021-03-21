using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Reverse_Analytics.Core;
using Reverse_Analytics.Views;

namespace Reverse.Modules.ModuleNames
{
    class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "LoginView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ActionView>();
            containerRegistry.RegisterForNavigation<LoginView>();
            containerRegistry.RegisterForNavigation<NavigationView>();
            containerRegistry.RegisterForNavigation<SidebarView>();
        }
    }
}
