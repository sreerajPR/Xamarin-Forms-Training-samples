using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RenderersDemo
{
  public partial class MainPage : ContentPage
  {
    MyEntry myEntry;

    Switch mySwitch;
    public MainPage()
    {
      InitializeComponent();

      
      myEntry = new MyEntry() {  VerticalOptions = LayoutOptions.CenterAndExpand, HasBorder = true };

       mySwitch = new Switch() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand };

       StackLayout stackLayout = new StackLayout() { Children = { myEntry, mySwitch }, Padding = new Thickness(5) };

       Content = stackLayout;

      //Content = new Entry() { VerticalOptions = LayoutOptions.CenterAndExpand, BackgroundColor = Xamarin.Forms.Color.OrangeRed };

      mySwitch.Toggled += MySwitch_Toggled;
    }

    private void MySwitch_Toggled(object sender, ToggledEventArgs e)
    {
      myEntry.HasBorder = e.Value;
    }
  }
}
