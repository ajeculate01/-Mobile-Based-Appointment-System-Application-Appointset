using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;


namespace AppointSystem
{
    [Activity(Label = "Parent")]
    public class Parent : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ParentActivityTwo);
        }
      
    }
}