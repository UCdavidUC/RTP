using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace RTP.Droid.Views
{
    [Activity(Label = "View for InicialViewModel")]
    public class InicialView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.InicialView);
        }
    }
}