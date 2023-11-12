using Prism.Regions;
using $ext_projectname$.Core.Mvvm;
using $ext_projectname$.Services.Interfaces;

namespace $safeprojectname$.ViewModels
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
