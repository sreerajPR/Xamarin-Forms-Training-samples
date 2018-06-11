using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPageDemo
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      navigateButton.Clicked += NavigateButton_Clicked;
    }

    private void NavigateButton_Clicked(object sender, EventArgs e)
    {
      //Demonstrate PushModal
      Navigation?.PushAsync(new Page2());
    }
  }
}
