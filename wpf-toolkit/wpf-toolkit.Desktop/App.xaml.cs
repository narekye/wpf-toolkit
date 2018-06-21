using System.Windows;

namespace wpf_toolkit.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var shell = new ShellViewModel();
            shell.Show();
        }
    }
}
