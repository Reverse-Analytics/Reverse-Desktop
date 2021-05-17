using Prism.Commands;
using Prism.Regions;
using Reverse.Infrastructure.Models.Enums;
using Reverse_Analytics.Core;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Windows.Media.Effects;

namespace Reverse.Modules.ModuleNames.ViewModels
{
    public class SidebarViewModel : RegionViewModelBase
    {
        public static double ControlOpacity { get; set; } = 1;
        public static Effect ControlEffect { get; set; }
        #region Commands

        public DelegateCommand<ActionEnum?> FastActionCommand { get; set; }
        public DelegateCommand GoHomeCommand { get; set; }

        #endregion

        public SidebarViewModel(IRegionManager regionManager) : base(regionManager)
        {
            FastActionCommand = new DelegateCommand<ActionEnum?>(FastAction);
            GoHomeCommand = new DelegateCommand(GoHome);
        }

        private void FastAction(ActionEnum? action)
        {
            if (!action.HasValue) throw new Exception("No parameter was provided for navigation");

            string viewName;

            switch (action)
            {
                case ActionEnum.Suppliers:
                    viewName = ViewNames.Suppliers;
                    break;
                case ActionEnum.Clients:
                    viewName = ViewNames.Clients;
                    break;
                case ActionEnum.Warehouse:
                    viewName = ViewNames.Warehouse;
                    break;
                case ActionEnum.Supplies:
                    viewName = ViewNames.Supplies;
                    break;
                case ActionEnum.Sales:
                    viewName = ViewNames.Sales;
                    break;
                case ActionEnum.Debts:
                    viewName = ViewNames.Debts;
                    break;
                case ActionEnum.Reports:
                    viewName = ViewNames.Reports;
                    break;
                case ActionEnum.Analytics:
                    viewName = ViewNames.Analytics;
                    break;
                case ActionEnum.Settings:
                    viewName = ViewNames.Settings;
                    break;
                default:
                    return;
            }

            if (!string.IsNullOrWhiteSpace(viewName))
                RegionManager.RequestNavigate(RegionNames.ContentRegion, viewName);
        }

        private void GoHome() =>
            RegionManager.RequestNavigate(RegionNames.ContentRegion, ViewNames.Suppliers);

    }
}
