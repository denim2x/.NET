using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyPhotos {
  public static partial class API {
    public static bool AddAttributeValue(this AttributeValue value) {
      using (var ctx = new MyPhotosContainer()) {
        bool bResult = false;
        if (value == null || value.AttributeId == 0)
          return bResult;

        if (value.Id == 0) {
          ctx.Entry(value).State = EntityState.Added;
          var attr = ctx.Attributes.Find(value.AttributeId);
          ctx.Entry(attr).State = EntityState.Unchanged;
          var media = ctx.Media.Find(value.MediaId);
          ctx.Entry(media).State = EntityState.Unchanged;
          ctx.SaveChanges();
          bResult = true;
        }

        return bResult;
      }
    }
    
    public static AttributeValue UpdateAttributeValue(this AttributeValue newValue) {
      using (var ctx = new MyPhotosContainer()) {
        var oldValue = ctx.AttributeValues.Find(newValue.Id);
        if ((oldValue.MediaId != newValue.MediaId) && (newValue.MediaId != 0)) {
          oldValue.MediaId = newValue.MediaId;
        }

        if ((oldValue.AttributeId != newValue.AttributeId) && (newValue.AttributeId != 0)) {
          oldValue.AttributeId = newValue.AttributeId;
        }
        ctx.SaveChanges();
        return oldValue;
      }
    }

    public static int DeleteAttributeValue(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Database.ExecuteSqlCommand("Delete From AttributeValue where Id = @p0", id);
      }
    }

    public static AttributeValue GetAttributeValueById(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        var items = from val in ctx.AttributeValues where (val.Id == id) select val;
        return items.Include(val => val.Attribute).Include(val => val.Media).Include(val => val.Media).SingleOrDefault();
      }
    }

    public static List<AttributeValue> GetAllAttributeValues() {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.AttributeValues.Include("Attributes").Include("Media").ToList();
      }
    }
  }
}
