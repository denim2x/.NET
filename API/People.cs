using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyPhotos {
  public static partial class API {
    public static bool AddPerson(this Person person) {
      using (var ctx = new MyPhotosContainer()) {
        bool bResult = false;
        if (person.Id == 0) {
          ctx.Entry(person).State = EntityState.Added;
          ctx.SaveChanges();
          bResult = true;
        }
        return bResult;
      }
    }

    public static Person UpdatePerson(this Person newPerson) {
      using (var ctx = new MyPhotosContainer()) {
        var oldPerson = ctx.People.Find(newPerson.Id);
        if (oldPerson == null)
          return null;

        oldPerson.FirstName = newPerson.FirstName;
        oldPerson.MiddleName = newPerson.MiddleName;
        oldPerson.LastName = newPerson.LastName;
        oldPerson.TelephoneNumber = newPerson.TelephoneNumber;
        ctx.SaveChanges();
        return oldPerson;
      }
    }

    public static int DeletePerson(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Database.ExecuteSqlCommand("Delete From Person where Id = @p0", id);
      }
    }

    public static Person GetPersonById(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        var items = from person in ctx.People where (person.Id == id) select person;
        return items?.SingleOrDefault();
      }
    }

    public static List<Person> GetAllPeople() {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.People.ToList();
      }
    }
  }
}
