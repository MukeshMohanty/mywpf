using System;
using ExperimentBusinessModels;
using MyWpf.Infrastructure;
using Prism.Commands;
using Prism.Events;

namespace ExperimentPerson.ViewModels
{
    public class PersonDetailDetailViewModel : ViewModelBase, IPersonDetailViewModel
    {
        private readonly IEventAggregator _eventAggregator;
        private Person _person;

        public PersonDetailDetailViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            //Person = new Person() {FirstName = "Mukesh", LastName = "Mohanty"};
            SaveCommand = new DelegateCommand<Person>(Save, CanSave);
            GlobalCommands.SaveAllCommand.RegisterCommand(SaveCommand);
            eventAggregator.GetEvent<PersonUpdatedEvent>().Subscribe(PersonUpdated); // should use this in status bar.
        }

        private void PersonUpdated(string obj)
        {
            LastUpdate = $"{obj} was updated ";
        }

        public DelegateCommand<Person> SaveCommand { get; set; }
        public Person SelectedPerson
        {
            get { return _person; }
            set { _person = value; OnPropertyChanged("SelectedPerson"); }
        }

        private void Save(Person value)
        {
            LastUpdate = DateTime.Now.AddYears(10).ToLongDateString();
            _eventAggregator.GetEvent<PersonUpdatedEvent>().Publish($"{LastUpdate}");
        }

        public string LastUpdate { get { return SelectedPerson?.LastUpdate; } set { SelectedPerson.LastUpdate = value; OnPropertyChanged("LastUpdate"); } }

        private bool CanSave(Person value)
        {
            return true;
        }
    }
}