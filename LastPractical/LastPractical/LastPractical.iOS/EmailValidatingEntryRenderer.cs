using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using LastPractical;
using LastPractical.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EmailValidatingEntry), typeof(EmailValidatingEntryRenderer))]
namespace LastPractical.iOS
{
  public class EmailValidatingEntryRenderer : EntryRenderer
  {

    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (Control != null && e.NewElement != null)
      {
        if ((e.NewElement as EmailValidatingEntry).IsValid)
        {
          Control.BackgroundColor = UIColor.White;
          Control.BorderStyle = UITextBorderStyle.Line;
        }
        else
        {
          Control.BackgroundColor = UIColor.Red;
          Control.BorderStyle = UITextBorderStyle.None;
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
          Control.BackgroundColor = UIColor.White;
          Control.BorderStyle = UITextBorderStyle.Line;
        }
        else
        {
          Control.BackgroundColor = UIColor.Red;
          Control.BorderStyle = UITextBorderStyle.None;
        }
      }
    }

  }
}