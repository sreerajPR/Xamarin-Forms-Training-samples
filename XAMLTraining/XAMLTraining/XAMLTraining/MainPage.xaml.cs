using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMLTraining
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }
    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
      label.Text = "Slider value is " + args.NewValue;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      slider.Value = 0;
    }
  }
}
