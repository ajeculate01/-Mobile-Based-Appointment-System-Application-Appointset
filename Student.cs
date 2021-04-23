using Android.App;
using Android.OS;


namespace AppointSystem
{
    [Activity(Label = "Student")]
    public class Student : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.StudentActivityTwo);
        }
    }
}


