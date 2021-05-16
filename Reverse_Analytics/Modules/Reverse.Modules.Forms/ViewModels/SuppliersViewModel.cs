using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Linq;

namespace Reverse.Modules.Forms.ViewModels
{
    public class SuppliersViewModel : RegionViewModelBase
    {
        IRegionNavigationJournal _journal;

        public DelegateCommand<string> SetSearchTextCommand { get; set; }

        private string _searchText;
        private ObservableCollection<Supplier> _suppliers;
        private List<Supplier> _suppliersData;

        public ObservableCollection<Supplier> Suppliers
        {
            get => _suppliers;
            set => SetProperty(ref _suppliers, value);
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Suppliers = new ObservableCollection<Supplier>(_suppliersData.Where(s => s.FullName.StartsWith(value)).ToList());
                }
                else
                {
                    Suppliers = new ObservableCollection<Supplier>(_suppliersData);
                }
                SetProperty(ref _searchText, value);
            }
        }

        public SuppliersViewModel(IRegionManager regionManager) : base(regionManager)
        {
            _suppliersData = new List<Supplier>
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

            _suppliers = new ObservableCollection<Supplier>(_suppliersData);
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
