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
using Transformer;
using Transformer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRendere))]

namespace Transformer.Droid
{
    public class CustomButtonRendere : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                Control.Background = Resources.GetDrawable(Resource.Drawable.CustomButton);
            }
        }
    }
}