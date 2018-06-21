using wpf_toolkit.Controls;
using wpf_toolkit.Desktop.ViewModels;

namespace wpf_toolkit.Desktop
{
    public class ShellViewModel : ViewModel<ShellView>
    {
        #region Properties

        public IViewModel Current { get; set; }

        #endregion

        #region Constructors 

        public ShellViewModel(/*inject viewmodels */)
        {
            Current = new MainViewModel();
        }

        #endregion

        #region Methods

        public void Show()
        {
            View.Show();
        }

        #endregion

    }
}
