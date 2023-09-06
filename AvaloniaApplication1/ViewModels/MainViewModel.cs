using Avalonia.Controls;
using Avalonia.Styling;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{

    private string _greeting = "Welcome to Avalonia. Finally!";
    public string Greeting
    {
        get => _greeting;
        set => this.RaiseAndSetIfChanged(ref _greeting, value);
    }


    public async void OnClickCommand()
    {
        Greeting = "OnClickCommand fired";
    }

    public async void OnClick2Command()
    {
        Greeting = "OnClick2Command fired";
    }


}
