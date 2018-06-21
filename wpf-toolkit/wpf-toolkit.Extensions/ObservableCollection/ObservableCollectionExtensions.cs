using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace wpf_toolkit.Extensions.ObservableCollection
{
    public static class ObservableCollectionExtensions
    {
        public static ObservableCollection<T> ToObservable<T>(this IEnumerable<T> collection)
        {
            return collection == null ? new ObservableCollection<T>() : new ObservableCollection<T>(collection);
        }
    }
}
