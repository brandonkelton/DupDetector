using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DupDetector.ViewModels
{
    public abstract class ViewModel : IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static readonly PropertyChangedEventArgs EmptyChangeArgs = new PropertyChangedEventArgs(string.Empty);
        private static readonly IDictionary<string, PropertyChangedEventArgs> ChangedProperties = new Dictionary<string, PropertyChangedEventArgs>();

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            OnPropertyChanged(ExpressionHelper.Name(expression));
        }

        protected virtual void OnPropertyChanged()
        {
            OnPropertyChanged(null);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                if (propertyName == null)
                {
                    handler(this, EmptyChangeArgs);
                }
                else
                {
                    PropertyChangedEventArgs args;
                    if (!ChangedProperties.TryGetValue(propertyName, out args))
                    {
                        args = new PropertyChangedEventArgs(propertyName);
                        ChangedProperties.Add(propertyName, args);
                    }

                    handler(this, args);
                }
            }
        }

        protected virtual bool SetPropertyAndNotify<T>(ref T existingValue, T newValue, Expression<Func<T>> expression)
        {
            if (EqualityComparer<T>.Default.Equals(existingValue, newValue))
            {
                return false;
            }

            existingValue = newValue;
            OnPropertyChanged(expression);

            return true;
        }
    }
}
