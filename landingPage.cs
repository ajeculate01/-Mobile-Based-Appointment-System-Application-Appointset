using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppointSystem
{
    [Activity(Label = "landingPage", MainLauncher = true)]
    public class landingPage : Activity
    {
        Button parent;
        Button Student;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LandingPageTwo);

            parent = FindViewById<Button>(Resource.Id.nonStudentButton);

            parent.Click += ParentClicked;

            Student = FindViewById<Button>(Resource.Id.StudentButton);

            Student.Click += StudentClicked;
        }
        private void ParentClicked(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Parent));
            StartActivity(i);
        }
        private void StudentClicked(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Student));
            StartActivity(i);
        }

    }
}