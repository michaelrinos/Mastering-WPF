using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels {
    public abstract class BaseSynchronizableDataModel<T> : BaseDataModel {

        #region Fields

        private T _OriginalState;

        #endregion // Fields

        #region Properties

        public T OriginialState {
            get => _OriginalState;
            private set => OriginialState = value;
        }

        #endregion // Properties

        #region Methods

        public abstract void CopyValuesFrom(object dataModel);
        public virtual T Clone() {
            T clone = new T();
            clone.CopyValuesFrom(this as T);
            return clone;
        }
        


        #endregion // Methods
    }
}
