using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Rendering;
using Avalonia.VisualTree;
using Avalonia.Win32.Interoperability;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
//using AvaloniaControls.Desktop;


namespace FormsWithAvalonia
{
    public partial class Form1 : Form
    {
        private readonly IRenderer _renderer;

        public Form1()
        {
            InitializeComponent();

            // Add the host control to the form. We have to do this manually because the WinFormsAvaloniaControlHost in design time is not working for some reason. 
            WinFormsAvaloniaControlHost avHost = new WinFormsAvaloniaControlHost();
            avHost.Name = "avHost";
            avHost .Dock = DockStyle.Fill;
            this.pnlAvControl .Controls.Add(avHost);

            // Create a new Avalonia control instance.
            AvaloniaApplication1.Views.MainView view = new AvaloniaApplication1.Views.MainView();

            // Bind the control to the view model.
            view.DataContext = new MainViewModel();
            view.InitializeComponent();

            avHost.Content = view;

        }

    }
}