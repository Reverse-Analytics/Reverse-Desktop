using Reverse.Infrastructure.Models;
using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;

namespace Reverse.Modules.Forms.ViewModels
{
    class ClientsViewModel : RegionViewModelBase
    {
        private IRegionNavigationJournal _journal;
        private readonly List<Client> _clients;
        public List<Client> Clients { get => _clients; }

        public ClientsViewModel(IRegionManager regionManager) : base(regionManager)
        {
            _clients = new List<Client>
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
