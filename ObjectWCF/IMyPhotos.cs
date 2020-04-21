using System.ServiceModel;

namespace ObjectWCF {
  [ServiceContract]
  public interface IMyPhotos : IMedia, IAttribute, IAttributeValue, IPerson {
  }
}
