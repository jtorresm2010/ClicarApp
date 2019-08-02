using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ClicarApp.Customs;
using ClicarApp.iOS.Customs;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryIOS))]

namespace ClicarApp.iOS.Customs
{
    class CustomEntryIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 5;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.FromRgba(117, 171, 64, 128).ToCGColor();/*Color.White.ToCGColor();*/
                Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }

    }
}