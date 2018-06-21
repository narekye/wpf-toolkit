using System.Windows;
using wpf_toolkit.Controls;
using wpf_toolkit.Desktop.Views;

namespace wpf_toolkit.Desktop.ViewModels
{
    public class MainViewModel : ViewModel<MainView>
    {
        #region Fields

        #endregion

        #region Constructors
        public MainViewModel()
        {
            ClickCommand = new RelayCommand(Execute);
        }
        #endregion

        #region Commands

        public RelayCommand ClickCommand { get; }

        #endregion

        #region Execute

        void Execute(object param)
        {
            MessageBox.Show("Clicked");
        }

        #endregion
    }
}
