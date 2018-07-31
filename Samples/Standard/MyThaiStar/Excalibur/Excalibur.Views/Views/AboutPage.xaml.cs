
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyThaiStar.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, WrapInNavigationPage = true, NoHistory = true)]
    public partial class AboutPage : MvxContentPage<AboutViewModel>
    {
		public AboutPage ()
		{
			InitializeComponent ();
		    ImgAbout.Source = ImageSource.FromResource("Excalibur.Resources.thairestaurant.jpg");
		    ImageBottom.Source = ImageSource.FromResource("Excalibur.Resources.starS.png");
        }
	}
}