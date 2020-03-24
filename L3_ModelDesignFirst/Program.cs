using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_ModelDesignFirst {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Test Model Designer First");
      TestPerson();
      TestOneToMany();
      TestManyToMany();
      Console.ReadKey();
    }

    static void TestPerson() {
      using (var context = new Model1Container()) {
        var p = new Person() {
          FirstName = "Nelson",
          MiddleName = "Rolihlahla",
          LastName = "Mandela",
          TelephoneNumber = "1234567890"
        };
        context.People.Add(p);
        context.SaveChanges();
        var items = context.People;
        foreach (var x in items) {
          Console.WriteLine("{0} {1}", x.Id, x.FirstName);
        }
      }
    }

    static void TestOneToMany() {
      Console.WriteLine("One to many association");
      using (var context = new ModelOneToManyContainer()) {
        var c = new Customer() {
          Name = "Customer 1",
          City = "Iasi"
        };
        var o1 = new Order() {
          TotalValue = 200,
          Date = DateTime.Now, 
          Customer = c
        };
        var o2 = new Order() {
          TotalValue = 300,
          Date = DateTime.Now, 
          Customer = c
        };
        context.Customers.Add(c);
        context.Orders.Add(o1);
        context.Orders.Add(o2);
        context.SaveChanges();
        var items = context.Customers;
        foreach (var x in items) {
          Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
          foreach (var ox in x.Orders) {
            Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
          }
        }
      }
    }

    static void TestManyToMany() {
      Console.WriteLine("Many to many association");
      using (var context = new ModelManyToManyContainer()) {
        var artist = new Artist() {
          FirstName = "Iron",
          LastName = "Maiden"
        };
        var album = new Album() {
          AlbumName = "Powerslave"
        };
        context.Artists.Add(artist);
        context.Albums.Add(album);
        context.SaveChanges();

        artist.Albums.Add(album);
        album.Artists.Add(artist);

        foreach (var a in context.Artists) {
          Console.WriteLine("Artist : {0}, {1}, {2}", a.ArtistId, a.FirstName, a.LastName);
          foreach (var al in a.Albums) {
            Console.WriteLine("\tAlbums: {0}, {1}", al.AlbumId, al.AlbumName);
          }
        }
      }
    }
  }
}
