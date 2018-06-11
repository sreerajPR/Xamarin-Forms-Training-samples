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
  public partial class Page3 : ContentPage
  {
    public Page3(string data = "")
    {
      InitializeComponent();
      navigateBackButton.Clicked += NavigateBackButton_Clicked;
      navigateToRootButton.Clicked += NavigateToRootButton_Clicked;
      if (!string.IsNullOrWhiteSpace(data))
      {
        label.Text = data;
      }
      insertPageBefore.Clicked += InsertPageBefore_Clicked;
    }

    private void InsertPageBefore_Clicked(object sender, EventArgs e)
    {
      Navigation?.InsertPageBefore(new MainPage(), this);
    }

    private void NavigateToRootButton_Clicked(object sender, EventArgs e)
    {
      //Demonstrate animate false
      Navigation?.PopToRootAsync(false);
    }

    private void NavigateBackButton_Clicked(object sender, EventArgs e)
    {
      //Demonstrate InsertPageBefore, RemovePage
      Navigation?.PopAsync();
    }
  }
}