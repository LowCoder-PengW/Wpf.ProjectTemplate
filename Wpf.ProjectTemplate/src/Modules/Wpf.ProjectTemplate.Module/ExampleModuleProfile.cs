using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Wpf.ProjectTemplate.Core;
using Wpf.ProjectTemplate.Module.Views; 

namespace Wpf.ProjectTemplate.Module
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