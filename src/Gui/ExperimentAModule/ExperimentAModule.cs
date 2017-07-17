using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using MyWpf.Infrastructure;
using Prism.Modularity;
using Prism.Regions;

namespace ExperimentAModule
{
    public class ExperimentAModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public ExperimentAModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            var region = _regionManager.Regions[RegionNames.ToolbarRegion];
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
        }
    }
}
