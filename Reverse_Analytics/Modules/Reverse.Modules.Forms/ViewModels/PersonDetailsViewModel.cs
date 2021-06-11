using Prism.Regions;
using Reverse_Analytics.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Modules.Forms.ViewModels
{
    public class PersonDetailsViewModel<T> : RegionViewModelBase
    {


        public PersonDetailsViewModel(RegionManager regionManager) : base(regionManager)
        {
        }
    }
}
