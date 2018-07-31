
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyThaiStar.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[MvxModalPresentation(WrapInNavigationPage = false)]
    public partial class DishFilterPage : MvxContentPage<DishFilterViewModel>
    {
        public DishFilterPage()
        {            
            InitializeComponent();
        }
    }
}