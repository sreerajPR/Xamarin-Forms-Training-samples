using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailDemo.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class HomePage : MasterDetailPage
  {
    public HomePage()
    {
      InitializeComponent();
      Master = new HomePageMaster();
      Detail = new HomePageDetail();
    }
  }
}