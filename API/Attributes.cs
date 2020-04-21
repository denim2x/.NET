using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyPhotos {
  public static partial class API {
    public static bool AddAttribute(this Attribute attribute) {
      using (var ctx = new MyPhotosContainer()) {
        bool bResult = false;
        if (attribute.Id == 0) {
          ctx.Entry(attribute).State = EntityState.Added;
          ctx.SaveChanges();
          bResult = true;
        }
        return bResult;
      }
    }

    public static Attribute UpdateAttribute(this Attribute newAttribute) {
      using (var ctx = new MyPhotosContainer()) {
        var oldAttribute = ctx.Attributes.Find(newAttribute.Id);
        if (oldAttribute == null)
          return null;

        oldAttribute.Name = newAttribute.Name;
        oldAttribute.Type = newAttribute.Type;
        oldAttribute.Values = newAttribute.Values;
        ctx.SaveChanges();
        return oldAttribute;
      }
    }

    public static int DeleteAttribute(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Database.ExecuteSqlCommand("Delete From Attribute where Id = @p0", id);
      }
    }

    public static Attribute GetAttributeById(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        var items = from attr in ctx.Attributes where (attr.Id == id) select attr;
        return items?.SingleOrDefault();
      }
    }

    public static List<Attribute> GetAllAttributes() {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Attributes.ToList();
      }
    }
  }
}
