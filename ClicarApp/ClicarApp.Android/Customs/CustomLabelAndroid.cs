using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ClicarApp.Customs;
using ClicarApp.Droid.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelAndroid))]

namespace ClicarApp.Droid.Customs
{
    class CustomLabelAndroid : LabelRenderer
    {
        public CustomLabelAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetColor(Android.Graphics.Color.Argb(51, 117, 171, 64));


                Control.SetBackground(gradientDrawable);
                Control.SetPadding(Control.PaddingTop, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
                Control.SetTextColor(Android.Graphics.Color.Rgb(117, 171, 64));
            }
        }





    }
}