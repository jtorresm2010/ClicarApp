using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ClicarApp.Droid.Customs;
using ClicarApp.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryAndroid))]

namespace ClicarApp.Droid.Customs
{
    class CustomEntryAndroid : EntryRenderer
    {
        public CustomEntryAndroid(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.Argb(128, 117, 171, 64));
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                
                
                Control.SetBackground(gradientDrawable);
                Control.SetHintTextColor(Android.Graphics.Color.Argb(128, 117, 171, 64));
                Control.SetPadding(90, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }

    }
}