using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using wpf_toolkit.Extensions.PropertyChanged;

namespace wpf_toolkit.Controls
{
    public abstract class ViewModel<T> : INotifyPropertyChanged, IDataErrorInfo, IViewModel where T:FrameworkElement 
    {
        #region View

        public T View { get; }

        #endregion

        #region IViewModel

        FrameworkElement IViewModel.View => View as FrameworkElement;

        #endregion

        #region Constructors

        protected ViewModel(T view = null)
        {
            View = view ?? ((T)Activator.CreateInstance(typeof(T)));
            View.DataContext = this;
        }

        #endregion

        #region IDataErrorInfo 

        public virtual string Error => this[null];
        public virtual string this[string columnName] => string.Empty;

        #endregion

        #region INotifyPropertyChnaged

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call by specifying the property to Notify
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="expr"></param>
        protected void Notify<TProp>(Expression<Func<TProp>> expr)
        {
            PropertyChanged.Raise(expr);
        }

        /// <summary>
        /// Calling with null automatically obtains the method or property name of the caller
        /// </summary>
        protected void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
