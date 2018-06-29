using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LastPractical
{
  public class ViewModel : INotifyPropertyChanged
  {
    public ViewModel()
    {
      ListItems = new ObservableCollection<Email>();

      AddEmailCommand = new Command(AddEmailButtonClicked);

      IsEmailValid = true;
    }

    public bool IsEmailValid { get; set; }

    public ObservableCollection<Email> ListItems { get; set; }

    public ICommand AddEmailCommand { get; set; }

    public string EmailText { get; set; }

    private void AddEmailButtonClicked()
    {
      if (IsEmailValid)
      {
        ListItems.Add(new Email(EmailText));
      }
      else
      {
        Application.Current.MainPage.DisplayAlert("Wrongly formatted Email", "Email is not valid", "Cancel");
      }

    }

    private void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }

  public class Email
  {
    public Email(string emailText)
    {
      EmailText = emailText;
    }
    public string EmailText { get; set; }
  }

}
