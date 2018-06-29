using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace LastPractical
{
  public class EmailValidatingEntry : Entry
  {
    public EmailValidatingEntry()
    {
      TextChanged += EmailValidatingEntry_TextChanged;
    }

    private void EmailValidatingEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
      IsValid = CheckEmailValidity();
    }

    private bool CheckEmailValidity()
    {
      Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
        + "@"
        + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

      if (String.IsNullOrWhiteSpace(Text) || !regex.IsMatch(Text))
      {
        return false;
      }

      return true;
    }

    public static readonly BindableProperty IsValidProperty =
        BindableProperty.Create("IsValid", typeof(bool), typeof(EmailValidatingEntry), true, BindingMode.TwoWay);

    public bool IsValid
    {
      get { return (bool)GetValue(IsValidProperty); }
      set { SetValue(IsValidProperty, value); }
    }
  }
}
