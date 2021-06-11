using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Modules.Forms.ViewModels
{
    public class PersonInformationViewModel : RegionViewModelBase
    {

        #region Properties

        private string _title;
        public string Title 
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion

        public PersonInformationViewModel(IRegionManager regionManager) : base(regionManager)
        {

        }
    }
}
