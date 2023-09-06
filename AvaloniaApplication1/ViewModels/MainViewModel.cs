using Avalonia.Controls;
using Avalonia.Styling;
using DialogHostAvalonia;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia. Finally!";


    public async void OnClickCommand()
    {
        //DialogHostAvalonia.Show("Hello World!");
        await DialogHost.Show("Test", "MainDialogHost");
        //var box = MessageBoxManager
        //    .GetMessageBoxStandard("Caption", "Are you sure you would like to delete appender_replace_page_1?",
        //        ButtonEnum.YesNo);

        //var result = await box.ShowAsync();
        // do something
    }

    public async void OnClick2Command()
    {
        //        var messageBoxCustomWindow = MessageBoxManager.GetMessageBoxCustom(new MessageBoxCustomParams
        //                        {
        //                            ContentMessage = "支持FontFamily",
        //                            FontFamily = "Microsoft YaHei,Simsun",
        //                            ButtonDefinitions = new[] {
        //                        new ButtonDefinition {Name = "My"},
        //                        new ButtonDefinition {Name = "Buttons"}
        //                            },
        //                            WindowStartupLocation = WindowStartupLocation.CenterOwner
        //                        });
        ////        var result = messageBoxCustomWindow.ShowAsPopupAsync((ContentControl)this);
    }

    public async void OnCloseDialog()
    {
        string test = "jids";
    }


}
