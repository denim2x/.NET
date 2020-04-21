using MyPhotos;

namespace ObjectWCF {
  public partial class MyPhotos : IMyPhotos {
    public bool AddAttributeValue(AttributeValue value) {
      return value.AddAttributeValue();
    }

    public int DeleteAttributeValue(int id) {
      return id.DeleteAttributeValue();
    }

    public AttributeValue GetAttributeValueById(int id) {
      return id.GetAttributeValueById();
    }

    public AttributeValue UpdateAttributeValue(AttributeValue value) {
      return value.UpdateAttributeValue();
    }
  }
}
