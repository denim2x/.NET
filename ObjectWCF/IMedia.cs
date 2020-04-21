using Global = MyPhotos;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF {
  [ServiceContract]
  public interface IMedia {
    [OperationContract]
    bool AddMedia(Global.Media media);

    [OperationContract]
    Global.Media UpdateMedia(Global.Media media);

    [OperationContract]
    int DeleteMedia(int id);

    [OperationContract]
    Global.Media GetMediaById(int id);

    [OperationContract]
    List<Global.Media> GetAllMedia();
  }
}
