namespace comtoolkitIssueMaui;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;

public partial class MainPageViewModel : INotifyPropertyChanged
{
    public ObservableCollection<string> myList { get; set; } = new()
    {
        "hello", "nope", "ok", "trees", "grass", "light"
    };

    [RelayCommand]
    public void MyMenuItemMethod()
    {
        Console.WriteLine("made it here");
    }

    [RelayCommand]
    public void MyMenuItemMethodParameter(string param)
    {
        Console.WriteLine("made it here with " + param);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
