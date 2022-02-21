using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using HelloMvvm;
using HelloMvvm.Droid;
using MvvmCross.Forms.Platforms.Android.Views;

namespace MvxForms.Droid
{
    [Activity(Label = "HelloMvvm", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, CoreApp, App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            return base.RunAppStartAsync(bundle);
        }
    }
}
