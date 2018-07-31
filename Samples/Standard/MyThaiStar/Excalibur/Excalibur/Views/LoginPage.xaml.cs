
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyThaiStar.Core.ViewModels;
using Xamarin.Forms;

namespace Excalibur.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class LoginPage : MvxContentPage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
            Img.Source = ImageSource.FromResource("Excalibur.Resources.thairestaurantlogin.jpg");
        }
    }
}