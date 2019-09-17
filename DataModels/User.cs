using DataModels.Interfaces;

namespace DataModels {
    public class User : IAuditable {
        private Auditable _Auditable;
        private string _Name;

        public Auditable Auditable { get => _Auditable; set => _Auditable = value; }
        public string Name { get => _Name; set { _Name = value; } }
    }
}