using Prism.Mvvm;
using Prism.Navigation;

namespace Reverse_Analytics.Core.MVVM
{
    public class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
