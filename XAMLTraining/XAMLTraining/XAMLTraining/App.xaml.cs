using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XAMLTraining
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      //MainPage = new MainPage();
      //ainPage = new ResourceDictionaryPage();
      
      MainPage = new NavigationPage(new Practical());
      (MainPage as NavigationPage).BarTextColor = Color.Black;
      (MainPage as NavigationPage).BarBackgroundColor = Color.White;
      
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
