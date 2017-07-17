using System.Windows;
using System.Windows.Controls;
using ExperimentPerson;
using Microsoft.Practices.Unity;
using MyWpf.Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

namespace MyWpf
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window) Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType<IShellViewModel, ShellViewModel>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof (ExperimentAModule.ExperimentAModule));
            catalog.AddModule(typeof (ExperimentBModule.ExperimentBModule));
            catalog.AddModule(typeof (PersonModule));
            return catalog;
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            return mappings;
        }
    }
}
