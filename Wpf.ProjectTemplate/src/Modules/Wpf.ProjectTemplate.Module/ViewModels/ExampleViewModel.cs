using Prism.Regions;
using Wpf.ProjectTemplate.Core.Mvvm;
using Wpf.ProjectTemplate.Services.Interfaces;

namespace Wpf.ProjectTemplate.Module.ViewModels
{
    public class ExampleViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ExampleViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
