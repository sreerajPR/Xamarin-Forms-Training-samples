using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StylesDemo
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      //Resources["dynamicLabelStyleResource"] = Resources["tealLabelStyle"];
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      //Resources["dynamicLabelStyleResource"] = Resources["dynamicLabelStyleResource"] == Resources["tealLabelStyle"] ? Resources["redLabelStyle"] : Resources["tealLabelStyle"];
    }
  }
}
