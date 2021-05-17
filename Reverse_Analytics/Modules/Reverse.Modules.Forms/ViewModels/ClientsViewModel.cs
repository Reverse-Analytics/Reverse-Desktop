using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Prism.Commands;
using System.Windows.Media.Effects;

namespace Reverse.Modules.Forms.ViewModels
{
    class ClientsViewModel : RegionViewModelBase
    {
        private IRegionNavigationJournal _journal;
        /*public static double ControlOpacity { get; set; }
        public static Effect ControlEffect { get; set; }*/

        public DelegateCommand<string> SetSearchTextCommand { get; set; }

        private string _searchText;
        private List<Client> _clientsData;
        private ObservableCollection<Client> _clients;

        public ObservableCollection<Client> Clients
        {
            get => _clients;
            set => SetProperty(ref _clients, value);
        }

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

        public ClientsViewModel(IRegionManager regionManager) : base(regionManager)
        {
            SetSearchTextCommand = new DelegateCommand<string>(SetSearchText);

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

        private void SetSearchText(string text) => SearchText = text;

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            _journal = navigationContext.NavigationService.Journal;
        }
    }
}
