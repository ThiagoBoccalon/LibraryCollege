using Prism.Navigation;
using Xamarin.Forms;

namespace LibraryCollege.Views
{
    public partial class MainMasterPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public static readonly BindableProperty IsPresentedAfterNavigationProperty =
            BindableProperty.Create(nameof(IsPresentedAfterNavigation), typeof(bool), typeof(MasterDetailPage), false);
        public MainMasterPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get => (bool)GetValue(IsPresentedAfterNavigationProperty);
            set => SetValue(IsPresentedAfterNavigationProperty, value);
        } 
    }
}