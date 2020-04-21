using System.Collections.Generic;
using System.ServiceModel;
using Global = MyPhotos;

namespace ObjectWCF {
  [ServiceContract]
  public interface IAttribute {
    [OperationContract]
    bool AddAttribute(Global.Attribute attribute);

    [OperationContract]
    Global.Attribute UpdateAttribute(Global.Attribute attribute);

    [OperationContract]
    int DeleteAttribute(int id);

    [OperationContract]
    Global.Attribute GetAttributeById(int id);

    [OperationContract]
    List<Global.Attribute> GetAllAttributes();
  }
}
