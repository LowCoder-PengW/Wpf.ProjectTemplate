using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using $safeprojectname$.Module; 
using $safeprojectname$.Services;
using $safeprojectname$.Services.Interfaces;
using $safeprojectname$.Views;

namespace $safeprojectname$
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
            moduleCatalog.AddModule<ExampleModuleProfile>();
        }
    }
}
