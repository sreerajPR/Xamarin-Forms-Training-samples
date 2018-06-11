using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenterDemo
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      EnterButton.Clicked += EnterButton_Clicked;
      NextPageButton.Clicked += NextPageButton_Clicked;

      MessagingCenter.Subscribe<NewPage, string>(this, "Name", (sender, text) =>
      {
        NameLabel.Text = "Name is " + text;
      });
    }

    private void NextPageButton_Clicked(object sender, EventArgs e)
    {
      Navigation?.PushAsync(new NewPage());
    }

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
      NameLabel.Text = "Name is " + NameField.Text;
    }
  }
}
