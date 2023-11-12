using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using $ext_projectname$.Core;
using $safeprojectname$.Views; 

namespace $safeprojectname$
{
    public class ExampleModuleProfile : IModule
    {
        private readonly IRegionManager _regionManager;

        public ExampleModuleProfile(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Example>();
        }
    }
}