using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenterDemo
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class NewPage : ContentPage
  {
    public NewPage()
    {
      InitializeComponent();
      EnterButton.Clicked += EnterButton_Clicked;
    }

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
      MessagingCenter.Send<NewPage, string>(this, "Name", NameField.Text);
    }
  }
}