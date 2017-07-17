using MyWpf.Infrastructure;
using Prism.Commands;
using Prism.Regions;

namespace ExperimentBModule
{
    public class ContentViewModel : ViewModelBase, IContentViewModel, INavigationAware, IRegionMemberLifetime {
        private int _pageViews;
        public int PageViews
        {
            get { return _pageViews; }
            set
            {
                _pageViews = value;
                OnPropertyChanged("PageViews");
            }
        }

        public ContentViewModel()
        {
            IncrementCommand = new DelegateCommand(() => PageViews++);
        }
        public DelegateCommand IncrementCommand { get; set; }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            PageViews++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public bool KeepAlive => false;
    }
}