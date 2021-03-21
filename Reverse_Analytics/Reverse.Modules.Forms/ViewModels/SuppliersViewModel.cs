using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;

namespace Reverse.Modules.Forms.ViewModels
{
    public class SuppliersViewModel : RegionViewModelBase
    {
        IRegionNavigationJournal _journal;

        public SuppliersViewModel(IRegionManager regionManager) : base(regionManager)
        {
        }

        private bool CanExecute()
        {
            return true;
        }

        private void Cancel()
        {
            _journal.GoBack();
        }

        private void Execute()
        {
            throw new NotImplementedException();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            _journal = navigationContext.NavigationService.Journal;
        }
    }
}
