using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ListviewDemo
{
  public class ListViewModel : INotifyPropertyChanged
  {
    private ListItemModel selectedItem;
    public ListItemModel SelectedItem
    {
      get { return selectedItem; }
      set
      {
        if (value != selectedItem)
        {
          selectedItem = value;
          Application.Current.MainPage.DisplayAlert(selectedItem.Title, selectedItem.Topic, "Cancel");
        }

      }
    }
    public ObservableCollection<ListItemModel> ListItems { get; set; }
    public ListViewModel()
    {
      ListItems = new ObservableCollection<ListItemModel>()
      {
        new ListItemModel("Programming Framework", "Xamarin", "ListViews"),
        new ListItemModel("Programming Framework", "Xamarin", "MVVM"),
        new ListItemModel("Programming Framework", "Xamarin", "Stykes"),
        new ListItemModel("Programming Framework", "Xamarin", "Grid"),
        new ListItemModel("Programming Framework", "Xamarin", "RelativeLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "AbsoluteLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "StackLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "ListViews"),
        new ListItemModel("Programming Framework", "Xamarin", "MVVM"),
        new ListItemModel("Programming Framework", "Xamarin", "Stykes"),
        new ListItemModel("Programming Framework", "Xamarin", "Grid"),
        new ListItemModel("Programming Framework", "Xamarin", "RelativeLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "AbsoluteLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "StackLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "ListViews"),
        new ListItemModel("Programming Framework", "Xamarin", "MVVM"),
        new ListItemModel("Programming Framework", "Xamarin", "Stykes"),
        new ListItemModel("Programming Framework", "Xamarin", "Grid"),
        new ListItemModel("Programming Framework", "Xamarin", "RelativeLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "AbsoluteLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "StackLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "ListViews"),
        new ListItemModel("Programming Framework", "Xamarin", "MVVM"),
        new ListItemModel("Programming Framework", "Xamarin", "Stykes"),
        new ListItemModel("Programming Framework", "Xamarin", "Grid"),
        new ListItemModel("Programming Framework", "Xamarin", "RelativeLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "AbsoluteLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "StackLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "ListViews"),
        new ListItemModel("Programming Framework", "Xamarin", "MVVM"),
        new ListItemModel("Programming Framework", "Xamarin", "Stykes"),
        new ListItemModel("Programming Framework", "Xamarin", "Grid"),
        new ListItemModel("Programming Framework", "Xamarin", "RelativeLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "AbsoluteLayout"),
        new ListItemModel("Programming Framework", "Xamarin", "StackLayout")
      };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }

  public class ListItemModel : INotifyPropertyChanged
  {
    public ListItemModel(string title, string name, string topic)
    {
      Title = title;
      Name = name;
      Topic = topic;
    }

    private string title;
    public string Title
    {
      get
      {
        return title;
      }
      set
      {
        if (title != value)
        {
          title = value;
          OnPropertyChanged("Title");
        }
      }
    }

    private string name;
    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        if (name != value)
        {
          name = value;
          OnPropertyChanged("Name");
        }
      }
    }

    private string topic;
    public string Topic
    {
      get
      {
        return topic;
      }
      set
      {
        if (topic != value)
        {
          topic = value;
          OnPropertyChanged("Topic");
        }
      }
    }


    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
