using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Xamarin.Forms;
using System.ComponentModel;
using Android.Graphics.Drawables;
using RenderersDemo.Droid;
using RenderersDemo;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace RenderersDemo.Droid
{
  public class MyEntryRenderer : EntryRenderer
  {
    Drawable backgroundDrawable;
    public MyEntryRenderer(Context context) : base(context)
    {
    }

    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (Control != null && e.NewElement != null)
      {
        
        if (backgroundDrawable == null && Control.Background != null)
        {
          backgroundDrawable = Control.Background;
        }
        if ((e.NewElement as MyEntry).HasBorder)
        {
          Control.Background = backgroundDrawable;
        }
        else
        {
          Control.Background = null;
          Control.SetBackgroundColor(Android.Graphics.Color.Pink);
        }
      }
    }

    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);

      if (e.PropertyName == MyEntry.HasBorderProperty.PropertyName)
      {
        if ((Element as MyEntry).HasBorder)
        {
          Control.Background = backgroundDrawable;
        }
        else
        {
          Control.Background = null;
          Control.SetBackgroundColor(Android.Graphics.Color.Pink);
        }
      }
    }

  }

}