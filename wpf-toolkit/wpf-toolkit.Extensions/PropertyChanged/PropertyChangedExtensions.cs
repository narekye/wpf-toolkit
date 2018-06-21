using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace wpf_toolkit.Extensions.PropertyChanged
{
    public static class PropertyChangedExtensions
    {
        public static void Raise<T>(this PropertyChangedEventHandler handler, Expression<Func<T>> selector)
        {
            if (handler == null) return;
            var memberExpression = selector.Body as MemberExpression;
            if (memberExpression == null) return;
            var sender = ((ConstantExpression)memberExpression.Expression).Value;
            handler(sender, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }
    }
}
