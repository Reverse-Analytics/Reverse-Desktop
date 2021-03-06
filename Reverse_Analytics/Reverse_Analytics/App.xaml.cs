using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Reverse.Services;
using Reverse.Services.Interfaces;
using Reverse.Modules.ModuleNames;
using Reverse.Modules.Forms;

namespace Reverse_Analytics
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<FormsModule>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //ConfigureUnhandledExceptionHandling();
        }
    }
}
