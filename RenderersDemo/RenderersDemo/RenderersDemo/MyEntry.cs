using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RenderersDemo
{
  public class MyEntry : Entry
  {
    public static readonly BindableProperty HasBorderProperty =
        BindableProperty.Create("HasBorder", typeof(bool), typeof(MyEntry), true);

    public bool HasBorder
    {
      get { return (bool)GetValue(HasBorderProperty); }
      set { SetValue(HasBorderProperty, value); }
    }

  }
}
