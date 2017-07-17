using System.Windows.Controls;
using ExperimentBusinessModels;
using ExperimentPerson.ViewModels;
using MyWpf.Infrastructure;
using Prism.Common;
using Prism.Regions;

namespace ExperimentPerson.Views
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl, IView
    {
        public PersonView(IPersonDetailViewModel detailViewModel)
        {
            InitializeComponent();
            ViewModel = detailViewModel;
            RegionContext.GetObservableContext(this).PropertyChanged += (s, e) =>
            {
                var context = (ObservableObject<object>)s;
                var selectedPerson = (Person)context.Value;
                (ViewModel as IPersonDetailViewModel).SelectedPerson = selectedPerson;
            };
        }

        public IViewModel ViewModel { get { return (IViewModel) DataContext; } set { DataContext = value; } }
    }
}
