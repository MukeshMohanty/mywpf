using System.Collections.ObjectModel;
using ExperimentBusinessModels;
using MyWpf.Infrastructure;
using Prism.Regions;

namespace ExperimentPerson.ViewModels
{
    public class PeopleViewModel : ViewModelBase, IPeopleViewModel, INavigationAware
    {
        public PeopleViewModel()
        {
            CreatePeople();
        }

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged("People");
            }
        }

        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = $"First {i}",
                    LastName = $"Last {i}"
                });
            }

            People = people;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }
    }
}