using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModels {
    public class BaseViewModel : INotifyPropertyChanged {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(params string[] propertyNames) {
            if (PropertyChanged != null) {
                foreach(string property in propertyNames) {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion // INotifyPropertyChanged Members
    }
}
