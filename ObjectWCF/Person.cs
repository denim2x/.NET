using MyPhotos;
using System.Collections.Generic;
using Global = MyPhotos;

namespace ObjectWCF {
  public partial class MyPhotos : IMyPhotos {
    public bool AddPerson(Person person) {
      return person.AddPerson();
    }

    public Person UpdatePerson(Person person) {
      return person.UpdatePerson();
    }

    public int DeletePerson(int id) {
      return id.DeletePerson();
    }

    public Person GetPersonById(int id) {
      return id.GetPersonById();
    }

    public List<Person> GetAllPeople() {
      return API.GetAllPeople();
    }
  }
}
