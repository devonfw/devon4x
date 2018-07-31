using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(WrapInNavigationPage = true, NoHistory = false)]
    public partial class TodoPage
    {
        public TodoPage()
        {
            InitializeComponent();
        }
    }
}
