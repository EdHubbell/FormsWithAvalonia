using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Rendering;
using Avalonia.VisualTree;
using Avalonia.Win32.Interoperability;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
using System.Windows.Forms;
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
            avHost.Dock = DockStyle.Fill;
            this.pnlAvControl.Controls.Add(avHost);

            // Create a new Avalonia control instance.
            AvaloniaApplication1.Views.MainView view = new AvaloniaApplication1.Views.MainView();

            // Bind the control to the view model.
            view.DataContext = new MainViewModel();


            avHost.Content = view;

        }

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            // Create a new Avalonia window instance.
            var window = new MainWindow();

            // Bind the control to the view model.
            MainViewModel mainViewModel = new MainViewModel();
            window.DataContext = mainViewModel;

            mainViewModel.Greeting = "This is the window greeting";

            window.Show();
        }
    }
}