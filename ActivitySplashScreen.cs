using Android.App;
using Android.Content;
using Android.OS;

namespace AppointSystem
{
    [Activity(Label = "ActivitySplashScreen")]
    public class ActivitySplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LayoutSplashDesign);

            Handler h = new Handler();
            h.PostDelayed(new System.Action(() => {
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);

            }), 5000);
        }
    }
}