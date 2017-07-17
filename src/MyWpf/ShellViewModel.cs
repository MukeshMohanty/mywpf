using System.Windows.Input;
using MyWpf.Infrastructure;
using Prism.Commands;
using Prism.Regions;

namespace MyWpf
{
    public class ShellViewModel : ViewModelBase, IShellViewModel
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand<object> NavigateCommand { get; private set; }

        public ShellViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<object>(Navigate);
            GlobalCommands.NavigateCommand.RegisterCommand(NavigateCommand);
        }

        private void Navigate(object navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate(RegionNames.ContentRegion, navigatePath.ToString(), NavigationComplete);
        }

        private void NavigationComplete(NavigationResult result)
        {

        }
    }

    public interface IShellViewModel : IViewModel
    {

    }
}