using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Reverse.Modules.ModuleNames.Views;
using Reverse_Analytics.Core;

namespace Reverse.Modules.ModuleNames
{
    public class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.SideBarRegion, ViewNames.SidebarView);
            _regionManager.RequestNavigate(RegionNames.ActionRegion, ViewNames.ActionView);
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
