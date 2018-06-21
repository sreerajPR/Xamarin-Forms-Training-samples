using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataBindingDemo
{
  public class ViewModel : INotifyPropertyChanged
  {
    private string firstName;
    public string FirstName
    {
      get { return firstName; }
      set
      {
        if (firstName != value)
        {
          firstName = value;
        // OnPropertyChanged("FullName");
        }
      }
    }
    private string secondName;
    public string SecondName
    {
      get { return secondName; }
      set
      {
        if (secondName != value)
        {
          secondName = value;
          //OnPropertyChanged("FullName");
        }
      }
    }
    public string FullName
    {
      get { return FirstName + " " + SecondName; }
    }
    
    public ICommand AppendNames
    {
      get
      {
        return new Command(() => { OnPropertyChanged("FullName"); });

      }
    }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
