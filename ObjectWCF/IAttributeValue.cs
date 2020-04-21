using System.ServiceModel;
using Global = MyPhotos;

namespace ObjectWCF {
  [ServiceContract]
  public interface IAttributeValue : IMedia, IAttribute {
    [OperationContract]
    bool AddAttributeValue(Global.AttributeValue value);

    [OperationContract]
    Global.AttributeValue UpdateAttributeValue(Global.AttributeValue value);

    [OperationContract]
    int DeleteAttributeValue(int id);

    [OperationContract]
    Global.AttributeValue GetAttributeValueById(int id);
  }
}
