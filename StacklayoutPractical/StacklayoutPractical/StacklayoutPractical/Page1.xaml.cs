using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StacklayoutPractical
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Page1 : ContentPage
  {
    public Page1()
    {
      InitializeComponent();

      nextPageButton.Clicked += NextPageButton_Clicked;
    }

    private void NextPageButton_Clicked(object sender, EventArgs e)
    {
      Navigation?.PushAsync(new MainPage());
    }
  }
}