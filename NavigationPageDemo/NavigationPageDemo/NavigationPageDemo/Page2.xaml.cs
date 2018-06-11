using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPageDemo
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Page2 : ContentPage
  {
    public Page2()
    {
      InitializeComponent();
      navigateButton.Clicked += NavigateButton_Clicked;
    }

    private void NavigateButton_Clicked(object sender, EventArgs e)
    {
      //Demonstrate Adding Data to new Page
      Navigation?.PushAsync(new Page3("Arun"));
    }
  }
}