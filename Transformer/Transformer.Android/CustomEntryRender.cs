using System.ComponentModel;
using Transformer;
using Transformer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]

namespace Transformer.Droid
{
    public sealed class CustomEntryRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                // var element = e.NewElement as CustomEntry;
                Control.Background = Resources.GetDrawable(Resource.Drawable.CustomEntry);
                Control.Text = null;
                // if (element != null) Control.Hint = element.Placeholder;
            }
        }

        //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        //{
        //  //  base.OnElementChanged(e);
        //    //if (Control != null)
        //    //{
        //    //    Control.SetBackgroundColor(Android.Graphics.Color.White);
        //    //    Control.SetTextColor(Android.Graphics.Color.Black);
        //    //    Control.SetText("Irshad",TextView.BufferType.Normal);

        //    //}
        //}

        //public override void Draw(Canvas canvas)
        //{
        //    CustomEntry cs = (CustomEntry)Element;
        //    Rect rcRect = new Rect();
        //    GetDrawingRect(rcRect);
        //    Rect interior = rcRect;
        //    interior.Inset((int)cs.StrokeThickness, (int)cs.StrokeThickness);
        //    Paint p = new Paint()
        //    {
        //        Color = cs.BackgroundColor.ToAndroid(Xamarin.Forms.Color.Transparent),
        //        //   TColor=cs.TextColor.ToAndroid();
        //        //Color = cs.TextColor.ToAndroid(),
        //        //   Color=cs.TextColor.ToAndroid(),
        //        AntiAlias = true,
        //    };
        //    canvas.DrawRoundRect(new RectF(interior), (float)cs.CornerRadius, (float)cs.CornerRadius, p);

        //    p.Color = cs.Stroke.ToAndroid();
        //    p.StrokeWidth = (float)cs.StrokeThickness;
        //    p.SetStyle(Paint.Style.Stroke);
        //    canvas.DrawRoundRect(new RectF(interior), (float)cs.CornerRadius, (float)cs.CornerRadius, p);

        //}
    }
}