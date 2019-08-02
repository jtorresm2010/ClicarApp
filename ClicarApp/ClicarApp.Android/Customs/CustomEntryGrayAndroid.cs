using Android.Content;
using ClicarApp.Droid.Customs;
using ClicarApp.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomEntryGray), typeof(CustomEntryGrayAndroid))]

namespace ClicarApp.Droid.Customs
{
    class CustomEntryGrayAndroid : EntryRenderer
    {
        public CustomEntryGrayAndroid(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.Argb(51,168, 168, 168));
                gradientDrawable.SetColor(Android.Graphics.Color.Rgb(248, 248, 248));


                Control.SetBackground(gradientDrawable);
                Control.SetHintTextColor(Android.Graphics.Color.Argb(153, 89, 89, 92));
                Control.SetPadding(20, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }

    }


}