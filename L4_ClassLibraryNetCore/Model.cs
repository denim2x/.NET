using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace L4_ClassLibraryNetCore.Model {
  public partial class Client {
    public int ClientId { get; set; }
    [MaxLength(20)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Email { get; set; }
    public ICollection<Order> Orders { get; set; }
    protected Client() { }
  }

  public partial class Order {
    public Client Client { get; set; }
    public ICollection<OrderDetails> OrderDetails { get; set; }
  }

  public partial class OrderDetails {
    public Order Order { get; set; }
    public Product Product { get; set; }
  }

  public partial class Product {
    public ICollection<OrderDetails> OrderDetails { get; set; }
  }
}