using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Reverse.Modules.Forms.Views.Clients;
using Reverse.Modules.Forms.Views.Suppliers;
using Reverse.Modules.Forms.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Modules.Forms
{
    public class FormsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public FormsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Suppliers>();
            containerRegistry.RegisterForNavigation<Clients>();
        }
    }
}
