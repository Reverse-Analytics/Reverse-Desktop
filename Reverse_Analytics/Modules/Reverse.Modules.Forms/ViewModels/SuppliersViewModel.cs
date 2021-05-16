using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;

namespace Reverse.Modules.Forms.ViewModels
{
    public class SuppliersViewModel : RegionViewModelBase
    {
        IRegionNavigationJournal _journal;
        private readonly List<Supplier> _suppliers;
        public List<Supplier> Suppliers { get => _suppliers; }

        public SuppliersViewModel(IRegionManager regionManager) : base(regionManager)
        {
            _suppliers = new List<Supplier>
            {
                new Supplier("Вазира", "+998(91) 773 21 02"),
                new Supplier("Володя", "+998(81) 922 95 13"),
                new Supplier("Вазира", "+998(91) 773 21 02"),
                new Supplier("Володя", "+998(81) 922 95 13"),
                new Supplier("Виктор", "+998(90) 253 42 65"),
                new Supplier("Ахмад ака", "+998(71) 203 22 22"),
                new Supplier("Аваз ака", "+998(90) 213 42 21"),
                new Supplier("Бахром ака", "+998(94) 412 31 52"),
                new Supplier("Ботир ака", "+998(93) 621 25 23"),
                new Supplier("Виктор", "+998(90) 253 42 65"),
                new Supplier("Ахмад ака", "+998(71) 203 22 22"),
                new Supplier("Аваз ака", "+998(90) 213 42 21"),
                new Supplier("Бахром ака", "+998(94) 412 31 52"),
                new Supplier("Ботир ака", "+998(93) 621 25 23"),
                new Supplier("Вазира", "+998(91) 773 21 02"),
                new Supplier("Володя", "+998(81) 922 95 13"),
                new Supplier("Виктор", "+998(90) 253 42 65"),
                new Supplier("Геннадий", "+998(94) 223 12 52")
            };
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
