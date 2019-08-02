using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ClicarApp.Customs;
using ClicarApp.iOS.Customs;

[assembly: ExportRenderer(typeof(CustomEntryGray), typeof(CustomEntryGrayIOS))]


namespace ClicarApp.iOS.Customs
{
    class CustomEntryGrayIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 5;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.FromRgba(168, 168, 168, 51).ToCGColor();
                Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }




    }
}