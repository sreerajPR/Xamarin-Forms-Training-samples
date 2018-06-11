using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LayoutDemo
{
  public class ScrollViewDemo : ContentPage
  {
    public ScrollViewDemo()
    {

      BoxView boxview = new BoxView
      {
        BackgroundColor = Color.Red,
        HeightRequest = 500,
        WidthRequest = 500
      };

      Content = new ScrollView
      {
        Padding = 50,
        Content = boxview,
        Orientation = ScrollOrientation.Horizontal,
        BackgroundColor = Color.Bisque
      };
      /*
      Label label = new Label
      {
        Text = loremIpsumText + loremIpsumText + loremIpsumText + loremIpsumText
      };

      Content = new ScrollView
      {
        Padding = 50,
        Content = label,
        Orientation = ScrollOrientation.Vertical
      };
      */

    }
    const string loremIpsumText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque faucibus finibus fringilla. Integer condimentum vestibulum volutpat. Interdum et malesuada fames ac ante ipsum primis in faucibus. Fusce libero turpis, iaculis vel purus ut, commodo interdum dui. Morbi volutpat dapibus erat ac placerat. Phasellus mattis, tellus ac molestie varius, enim ante dapibus mauris, non consequat dolor quam ut justo. Pellentesque cursus augue quam, nec molestie erat venenatis eget. Maecenas vitae eros ut ex maximus dictum quis vel mauris." +
      "Nulla elementum in est ac elementum.Duis blandit lorem dignissim, malesuada tellus et, ullamcorper urna.Aenean sit amet lectus vel elit aliquet maximus.Suspendisse ut efficitur mauris.Donec ut neque nisi. Duis ullamcorper ante in mauris pulvinar, pellentesque viverra metus semper. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Vivamus sodales quam non risus interdum viverra. ";

  }
}