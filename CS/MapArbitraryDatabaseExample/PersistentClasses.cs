using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DXSample {
    [NonPersistent]
    public class BasePersistentClass :XPLiteObject {
        public BasePersistentClass(Session session) : base(session) { }
        public BasePersistentClass(Session session, XPClassInfo classInfo) : base(session, classInfo) { }
    }
}