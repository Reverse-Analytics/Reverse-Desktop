using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Prism.Commands;
using System.Windows.Media.Effects;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace Reverse.Modules.Forms.ViewModels.Clients
{
    class ClientsViewModel : RegionViewModelBase
    {
        private IRegionNavigationJournal _journal;
        /*public static double ControlOpacity { get; set; }
        public static Effect ControlEffect { get; set; }*/

        public string PersonName { get; set; } = "Some Names";
        public string ClientsNames { get; set; } = "Client name";

        #region Commands

        public DelegateCommand<string> SetSearchTextCommand { get; set; }
        public DelegateCommand<Client> NavigateToDetailsCommand { get; set; }
        public DelegateCommand CloseClientDetailsCommand { get; set; }
        public DelegateCommand<Client> DataGridDoubleClickCommand { get; set; }

        #endregion

        #region Customer details Properties

        private string _customerFullName;
        public string CustomerFullName
        {
            get => _customerFullName;
            set
            {
                SetProperty(ref _customerFullName, value);
                SelectedClient.FullName = value;
            }
        }

        private string _customerAdress;
        public string CustomerAddress 
        {
            get => _customerAdress;
            set
            {
                SetProperty(ref _customerAdress, value);
                SelectedClient.Address = value;
            }
        }

        private string _clientPhoneNumber;
        public string ClientPhoneNumber 
        {
            get => _clientPhoneNumber;
            set
            {
                SetProperty(ref _clientPhoneNumber, value);
                SelectedClient.PhoneNumber = _clientPhoneNumber;
            }
        }

        private double _clientBonus;
        public double ClientBonus 
        {
            get => _clientBonus;
            set
            {
                SetProperty(ref _clientBonus, value);
                SelectedClient.Bonus = value;
            }
        }

        #endregion

        #region Properties

        private Client _selectedClient;
        public Client SelectedClient 
        {
            get => _selectedClient;
            set
            {
                SetProperty(ref _selectedClient, value);
                CustomerFullName = _selectedClient.FullName;
                CustomerAddress = _selectedClient.Address;
                ClientPhoneNumber = _selectedClient.PhoneNumber;
                ClientBonus = _selectedClient.Bonus;
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
                    Clients = new ObservableCollection<Client>(_clientsData.Where(s => s.FullName.StartsWith(value)).ToList());
                }
                else
                {
                    Clients = new ObservableCollection<Client>(_clientsData);
                }
                SetProperty(ref _searchText, value);
            }
        }

        private double _contentPanelOpacity;
        private Effect _contentPanelEffect;
        private bool _contentPanelEnabled;

        public double ContentPanelOpacity 
        {
            get => _contentPanelOpacity;
            set => SetProperty(ref _contentPanelOpacity, value);
        }
        public Effect ContentPanelEffect 
        {
            get => _contentPanelEffect;
            set => SetProperty(ref _contentPanelEffect, value);
        }
        public bool ContentPanelEnabled 
        {
            get => _contentPanelEnabled;
            set => SetProperty(ref _contentPanelEnabled, value);
        }

        private Visibility _clientDetailsVisibility;
        public Visibility ClientDetailsVisibility 
        {
            get => _clientDetailsVisibility;
            set => SetProperty(ref _clientDetailsVisibility, value);
        }

        #endregion

        #region Collections

        private List<Client> _clientsData;
        private ObservableCollection<Client> _clients;

        public ObservableCollection<Client> Clients
        {
            get => _clients;
            set => SetProperty(ref _clients, value);
        }

        #endregion

        #region Constructors

        public ClientsViewModel(IRegionManager regionManager) : base(regionManager)
        {
            SetSearchTextCommand = new DelegateCommand<string>(SetSearchText);
            NavigateToDetailsCommand = new DelegateCommand<Client>(FastAction);
            CloseClientDetailsCommand = new DelegateCommand(ClosePersonDetailsControl);
            DataGridDoubleClickCommand = new DelegateCommand<Client>(DataGridDoubleClicked);

            ContentPanelOpacity = 1;
            ContentPanelEffect = null;
            ContentPanelEnabled = true;

            ClientDetailsVisibility = Visibility.Hidden;

            _clientsData = new List<Client>
            {
                new Client("Вазира", "+998(91) 773 21 02"),
                new Client("Володя", "+998(81) 922 95 13"),
                new Client("Вазира", "+998(91) 773 21 02"),
                new Client("Володя", "+998(81) 922 95 13"),
                new Client("Виктор", "+998(90) 253 42 65"),
                new Client("Ахмад ака", "+998(71) 203 22 22"),
                new Client("Аваз ака", "+998(90) 213 42 21"),
                new Client("Бахром ака", "+998(94) 412 31 52"),
                new Client("Ботир ака", "+998(93) 621 25 23"),
                new Client("Виктор", "+998(90) 253 42 65"),
                new Client("Ахмад ака", "+998(71) 203 22 22"),
                new Client("Аваз ака", "+998(90) 213 42 21"),
                new Client("Бахром ака", "+998(94) 412 31 52"),
                new Client("Ботир ака", "+998(93) 621 25 23"),
                new Client("Вазира", "+998(91) 773 21 02"),
                new Client("Володя", "+998(81) 922 95 13"),
                new Client("Виктор", "+998(90) 253 42 65"),
                new Client("Геннадий", "+998(94) 223 12 52")
            };
            _clients = new ObservableCollection<Client>(_clientsData);
        }

        #endregion

        #region Command methods

        private void FastAction(Client client)
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
        
        private void ClosePersonDetailsControl()
        {
            ContentPanelOpacity = 1;
            ContentPanelEffect = null;
            ContentPanelEnabled = true;

            ClientDetailsVisibility = Visibility.Hidden;
        }

        private void DataGridDoubleClicked(Client selectedClient)
        {
            ContentPanelOpacity = 0.5;
            ContentPanelEffect = new BlurEffect();
            ContentPanelEnabled = false;

            ClientDetailsVisibility = Visibility.Visible;
        }

        #endregion

        #region Helper methods

        private void SetSearchText(string text) => SearchText = text;

        #endregion
    }
}
