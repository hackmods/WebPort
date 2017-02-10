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
using Xamarin.Forms;
using WebPort;
using WebPort.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace WebPort.Droid
{
    /// <summary>
    /// Add the FontAwesome.ttf to the Assets folder and mark as "Android Asset"
    /// </summary>
    public class FontAwesomeIconRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, FontAwesomeIcon.Typeface + ".ttf");
            }
        }
    }
}