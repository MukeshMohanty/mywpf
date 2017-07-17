using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExperimentBModule.Navigation;
using Microsoft.Practices.Unity;
using MyWpf.Infrastructure;
using Prism.Modularity;
using Prism.Regions;

namespace ExperimentBModule
{
    public class ExperimentBModule : ModuleBase
    {
        
        public ExperimentBModule(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {
        }
        
        protected override void InitializeModule()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof (NavButtonView));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IContentViewModel, ContentViewModel>();
            Container.RegisterTypeForNavigation<ContentView>();

        }
    }
}
