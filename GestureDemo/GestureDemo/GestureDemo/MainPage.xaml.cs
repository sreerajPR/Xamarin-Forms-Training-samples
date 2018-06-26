using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureDemo
{
  public partial class MainPage : ContentPage
  {
    private Double translationX, translationY;
    public MainPage()
    {
      InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
      bool response = await DisplayAlert("Blue Box Tapped", "Tap was registered", "OK", "Cancel");
      Debug.WriteLine(response);
    }

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
      switch (e.StatusType)
      {
        case GestureStatus.Running:
          blueBox.TranslationX = translationX + e.TotalX;
          blueBox.TranslationY = translationY + e.TotalY;
          break;

        case GestureStatus.Completed:
          translationX = blueBox.TranslationX;
          translationY = blueBox.TranslationY;
          break;
      }
    }

    private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {

    }
  }
}
