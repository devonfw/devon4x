
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyThaiStar.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, WrapInNavigationPage = false)]
    public partial class MasterDetailPage : MvxContentPage<MasterDetailViewModel>
    {
        public MasterDetailPage()
        {
            InitializeComponent();

            ImageTop.Source = ImageSource.FromResource("Excalibur.Resources.thairestaurantlogin.jpg");
            ImageBottom.Source = ImageSource.FromResource("Excalibur.Resources.starS.png");
        }
    }
}