using Excalibur.Views;
using Excalibur;
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;
using MvvmCross;

namespace Excalibur.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Excalibur.App, Excalibur.Views.App>, Excalibur.App, Excalibur.Views.App>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes() { TextColor = UIColor.White });

            //UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(65, 105, 225); //blue            
            UINavigationBar.Appearance.TintColor = UIColor.FromRGB(33, 33, 33); //darkgray
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(33, 33, 33); //darkgray

            //var setup = new Setup(this, Window);
            //setup.Initialize();

            //var startup = Mvx.Resolve<IMvxAppStart>();
            //startup.Start();

            //LoadApplication(setup.FormsApplication);

            Window.MakeKeyAndVisible();

            return base.FinishedLaunching(app, options);
        }
    }   
}
