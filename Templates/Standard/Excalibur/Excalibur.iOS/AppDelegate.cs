using Excalibur.Views;
using Excalibur;
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;



namespace Excalibur.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Excalibur.App, Excalibur.Views.App>, Excalibur.App, Excalibur.Views.App>
    {
    }   
}
