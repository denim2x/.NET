using System.Collections.Generic;
using System.ServiceModel;
using Global = MyPhotos;

namespace ObjectWCF {
  [ServiceContract]
  public interface IPerson {
    [OperationContract]
    bool AddPerson(Global.Person person);

    [OperationContract]
    Global.Person UpdatePerson(Global.Person newPerson);

    [OperationContract]
    int DeletePerson(int id);

    [OperationContract]
    Global.Person GetPersonById(int id);

    [OperationContract]
    List<Global.Person> GetAllPeople();
  }
}
