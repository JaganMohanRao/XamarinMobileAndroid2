using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OnlyDatePicker.Droid
{
	[Activity (Label = "Job Search", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
    {
        DatePicker datePicker;
        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
            var btnSearch = FindViewById<Button>(Resource.Id.btnjobSearch);
            //datePicker = FindViewById<DatePicker>(Resource.Id.datePicker);
            //var btnChange = FindViewById<Button>(Resource.Id.change_date_button);
            //var txtDate = FindViewById<TextView>(Resource.Id.txtViewDate);
            var gridLayout = FindViewById<GridLayout>(Resource.Id.grdLayoutSearch);


            //txtDate.Text=(getDate());
            //btnChange.Click += (s, e) =>
            //{
            //    txtDate.Text = getDate();
            //};

            btnSearch.Click += (s, e) =>
            {
                //gridLayout.Visibility
                GridLayout view = FindViewById<GridLayout>(Resource.Id.grdLayoutSearch);
                //view.setText("Add your text here");
                //view.Visibility=.setVisibility(View.VISIBLE);
            };
        }

        
        private string getDate()
        {
            Java.Lang.StringBuilder strCurrentDate = new Java.Lang.StringBuilder();
            int month = datePicker.Month + 1;
            strCurrentDate.Append("Date: " + month + "/" + datePicker.DayOfMonth + "/" + datePicker.Year);
            return strCurrentDate.ToString();

        }
    }
}


