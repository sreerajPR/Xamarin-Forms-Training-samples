using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LastPractical;
using LastPractical.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EmailValidatingEntry), typeof(EmailValidatingEntryRenderer))]
namespace LastPractical.Droid
{
  public class EmailValidatingEntryRenderer : EntryRenderer
  {
    Drawable backgroundDrawable;
    public EmailValidatingEntryRenderer(Context context) : base(context)
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
        if ((e.NewElement as EmailValidatingEntry).IsValid)
        {
          Control.Background = backgroundDrawable;
        }
        else
        {
          Control.Background = null;
          Control.SetBackgroundColor(Android.Graphics.Color.Red);
        }
      }
    }

    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);

      if (e.PropertyName == EmailValidatingEntry.IsValidProperty.PropertyName)
      {
        if ((Element as EmailValidatingEntry).IsValid)
        {
          Control.Background = backgroundDrawable;
        }
        else
        {
          Control.Background = null;
          Control.SetBackgroundColor(Android.Graphics.Color.Red);
        }
      }
    }
  }
}