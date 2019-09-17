using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataModels {
    public class BaseDataModel : INotifyPropertyChanged {
        #region Fields

        private DateTime _CreatedOn;
        private DateTime? _UpdatedOn;
        private User _CreatedBy, _UpdatedBy;


        #endregion // Fields

        #region Properties

        public DateTime CreatedOn { get => _CreatedOn; set { _CreatedOn = value; NotifyPropertyChanged(); } }
        public DateTime? UpdatedOn { get => _UpdatedOn; set { _UpdatedOn = value; NotifyPropertyChanged(); } }
        public User CreatedBy { get => _CreatedBy; set { _CreatedBy = value; NotifyPropertyChanged(); } }
        public User UpdatedBy { get => _UpdatedBy; set { _UpdatedBy = value; NotifyPropertyChanged(); } }


        #endregion // Properties

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
