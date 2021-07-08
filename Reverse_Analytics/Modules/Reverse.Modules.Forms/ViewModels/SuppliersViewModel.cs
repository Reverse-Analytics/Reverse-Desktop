using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media.Effects;
using System.Windows;

namespace Reverse.Modules.Forms.ViewModels.Suppliers
{
    public class SuppliersViewModel : RegionViewModelBase
    {
        IRegionNavigationJournal _journal;

        #region Commands

        public DelegateCommand<string> SetSearchTextCommand { get; set; }
        public DelegateCommand<Supplier> NavigateToDetailsCommand { get; set; }
        public DelegateCommand CloseSupplierDetailsCommand { get; set; }
        public DelegateCommand<Supplier> DataGridDoubleClickCommand { get; set; }

        #endregion

        #region Properties

        private Supplier _selectedSupplier;
        public Supplier SelectedSupplier
        {
            get => _selectedSupplier;
            set
            {
                SetProperty(ref _selectedSupplier, value);
                SupplierFullName = _selectedSupplier.FullName;
                SupplierAddress = _selectedSupplier.Address;
                SupplierPhoneNumber = _selectedSupplier.PhoneNumber;
            }
        }

        private string _searchText;
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

        private double _contentPanelOpacity;
        public double ContentPanelOpacity
        {
            get => _contentPanelOpacity;
            set => SetProperty(ref _contentPanelOpacity, value);
        }

        private Effect _contentPanelEffect;
        public Effect ContentPanelEffect
        {
            get => _contentPanelEffect;
            set => SetProperty(ref _contentPanelEffect, value);
        }

        private bool _contentPanelEnabled;
        public bool ContentPanelEnabled
        {
            get => _contentPanelEnabled;
            set => SetProperty(ref _contentPanelEnabled, value);
        }

        private Visibility _supplierDetailsVisibility;
        public Visibility SupplierDetailsVisibility
        {
            get => _supplierDetailsVisibility;
            set => SetProperty(ref _supplierDetailsVisibility, value);
        }

        #endregion

        #region Supplier details Properties
        private string _supplierFullName;
        public string SupplierFullName 
        {
            get => _supplierFullName;
            set
            {
                SetProperty(ref _supplierFullName, value);
                SelectedSupplier.FullName = _supplierFullName;
            }
        }

        private string _supplierPhoneNumber;
        public string SupplierPhoneNumber 
        {
            get => _supplierAddress;
            set
            {
                SetProperty(ref _supplierPhoneNumber, value);
                SelectedSupplier.PhoneNumber = _supplierPhoneNumber;
            }
        }

        private string _supplierAddress;
        public string SupplierAddress 
        {
            get => _supplierAddress;
            set
            {
                SetProperty(ref _supplierAddress, value);
                SelectedSupplier.Address = _supplierAddress;
            }
        }

        #endregion

        #region Collections

        private List<Supplier> _suppliersData;

        #region Observable Collections

        private ObservableCollection<Supplier> _suppliers;
        public ObservableCollection<Supplier> Suppliers
        {
            get => _suppliers;
            set => SetProperty(ref _suppliers, value);
        }

        #endregion

        #endregion

        #region Constructors

        public SuppliersViewModel(IRegionManager regionManager) : base(regionManager)
        {
            SetSearchTextCommand = new DelegateCommand<string>(SetSearchText);
            NavigateToDetailsCommand = new DelegateCommand<Supplier>(FastAction);
            CloseSupplierDetailsCommand = new DelegateCommand(CloseSupplierDetailsControl);
            DataGridDoubleClickCommand = new DelegateCommand<Supplier>(DataGridDoubleClicked);

            ContentPanelOpacity = 1;
            ContentPanelEffect = null;
            ContentPanelEnabled = true;
            SupplierDetailsVisibility = Visibility.Hidden;

            _suppliersData = new List<Supplier>
            {
                new Supplier("Вазира", "+998(91) 773 21 02"),
                new Supplier("Володя", "+998(81) 922 95 13"),
                new Supplier("Вазира", "+998(91) 773 21 02"),
                new Supplier("Володя", "+998(81) 922 95 13"),
                new Supplier("Виктор", "+998(90) 253 42 65"),
                //new Supplier("Ахмад ака", "+998(71) 203 22 22"),
                //new Supplier("Аваз ака", "+998(90) 213 42 21"),
                //new Supplier("Бахром ака", "+998(94) 412 31 52"),
                //new Supplier("Ботир ака", "+998(93) 621 25 23"),
                //new Supplier("Виктор", "+998(90) 253 42 65"),
                //new Supplier("Ахмад ака", "+998(71) 203 22 22"),
                //new Supplier("Аваз ака", "+998(90) 213 42 21"),
                //new Supplier("Бахром ака", "+998(94) 412 31 52"),
                //new Supplier("Ботир ака", "+998(93) 621 25 23"),
                //new Supplier("Вазира", "+998(91) 773 21 02"),
                //new Supplier("Володя", "+998(81) 922 95 13"),
                //new Supplier("Виктор", "+998(90) 253 42 65"),
                //new Supplier("Геннадий", "+998(94) 223 12 52")
            };

            _suppliers = new ObservableCollection<Supplier>(_suppliersData);
        }

        #endregion

        #region Command methods

        private void FastAction(Supplier client)
        {
            int g = 0;
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

        private void CloseSupplierDetailsControl()
        {
            ContentPanelOpacity = 1;
            ContentPanelEffect = null;
            ContentPanelEnabled = true;

            SupplierDetailsVisibility = Visibility.Hidden;
        }

        private void DataGridDoubleClicked(Supplier selectedSupplier)
        {
            ContentPanelOpacity = 0.5;
            ContentPanelEffect = new BlurEffect();
            ContentPanelEnabled = false;

            SupplierDetailsVisibility = Visibility.Visible;
        }

        #endregion

        #region Helper methods

        private void SetSearchText(string text) => SearchText = text;

        #endregion
    }
}
