﻿using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace stDelivery
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var btnPizza = FindViewById(Resource.Id.btnPizza);
            btnPizza.Click += delegate
            {
                Intent menuActivity = new Intent(this, typeof(FoodMenuActivity));
                menuActivity.PutExtra("Type", 0);
                this.StartActivity(menuActivity);
            };

            var btnHam = FindViewById(Resource.Id.btnHamburger);
            btnHam.Click += delegate
            {
                Intent menuActivity = new Intent(this, typeof(FoodMenuActivity));
                menuActivity.PutExtra("Type", 1);
                this.StartActivity(menuActivity);
            };

            var btnDesert = FindViewById(Resource.Id.btnDesert);
            btnDesert.Click += delegate
            {
                Intent menuActivity = new Intent(this, typeof(FoodMenuActivity));
                menuActivity.PutExtra("Type", 2);
                this.StartActivity(menuActivity);
            };


        }



    }
}

