using MvvmCross.Forms.Presenters.Attributes;
using System;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class LoginPage
    {
        public LoginPage()
        {

            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                var e = $"{ex.Message} : {ex.InnerException}";
            }
        }
    }
}
