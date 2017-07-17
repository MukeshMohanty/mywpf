using System;
using ExperimentBusinessModels;
using MyWpf.Infrastructure;

namespace ExperimentPerson.ViewModels
{
    public interface IPersonDetailViewModel : IViewModel { Person SelectedPerson { get; set; } }
    public interface IPeopleViewModel : IViewModel
    {

    }
}