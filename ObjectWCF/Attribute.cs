using MyPhotos;
using System.Collections.Generic;
using Global = MyPhotos;

namespace ObjectWCF {
  public partial class MyPhotos : IMyPhotos {
    public bool AddAttribute(Attribute attribute) {
      return attribute.AddAttribute();
    }

    public int DeleteAttribute(int id) {
      return id.DeleteAttribute();
    }

    public List<Attribute> GetAllAttributes() {
      return API.GetAllAttributes();
    }

    public Attribute GetAttributeById(int id) {
      return id.GetAttributeById();
    }

    public Attribute UpdateAttribute(Attribute attribute) {
      return attribute.UpdateAttribute();
    }
  }
}
