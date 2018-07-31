using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Excalibur.Views;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using ImageCircle.Forms.Plugin.Droid;

namespace Excalibur.Droid
{

    [Activity(Label = "Excalibur", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class RootActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Excalibur.App, Excalibur.Views.App>, Excalibur.App, Excalibur.Views.App>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            ImageCircleRenderer.Init();
            //TagEntryRenderer.Init();
            base.OnCreate(bundle);
        }
    }
}

