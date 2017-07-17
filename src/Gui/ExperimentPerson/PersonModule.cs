using ExperimentPerson.Navigation;
using ExperimentPerson.ViewModels;
using ExperimentPerson.Views;
using Microsoft.Practices.Unity;
using MyWpf.Infrastructure;
using Prism.Modularity;
using Prism.Regions;

namespace ExperimentPerson
{
    public class PersonModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public PersonModule(IUnityContainer container, IRegionManager regionManager)
        {
            this._container = container;
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterType<IPersonDetailViewModel, PersonDetailDetailViewModel>();
            _container.RegisterType<IPeopleViewModel, PeopleViewModel>();
            _container.RegisterType<PersonView>();
            //_container.RegisterType<PeopleView>();
            _container.RegisterTypeForNavigation<PeopleView>();

            _regionManager.Regions[RegionNames.ToolbarRegion].Add(_container.Resolve<PeopleNavButtonView>());
            _regionManager.Regions[RegionNames.ContentRegion].Add(_container.Resolve<PeopleView>());
            _regionManager.RegisterViewWithRegion("PersonDetailsRegion", typeof (PersonView));
        }
    }
}
