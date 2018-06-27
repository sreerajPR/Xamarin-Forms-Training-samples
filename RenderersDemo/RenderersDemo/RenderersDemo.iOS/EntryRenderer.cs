using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using RenderersDemo;
using RenderersDemo.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace RenderersDemo.iOS
{
  public class MyEntryRenderer : EntryRenderer
  {
    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (Control != null && e.NewElement != null)
      {
        if ((e.NewElement as MyEntry).HasBorder)
        {
          Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
          Control.BorderStyle = UITextBorderStyle.Line;
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
          Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
          Control.BorderStyle = UITextBorderStyle.Line;
        }
        else
        {
          Control.BorderStyle = UITextBorderStyle.RoundedRect;
        }
      }
    }
  }
}