using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyPhotos {
  public static partial class API {
    public static bool AddMedia(this Media media) {
      using (var ctx = new MyPhotosContainer()) {
        bool bResult = false;
        if (media.Id == 0) {
          ctx.Entry(media).State = EntityState.Added;
          ctx.SaveChanges();
          bResult = true;
        }
        return bResult;
      }
    }

    public static Media UpdateMedia(this Media newMedia) {
      using (var ctx = new MyPhotosContainer()) {
        var oldMedia = ctx.Media.Find(newMedia.Id);
        if (oldMedia == null)
          return null;

        oldMedia.Deleted = newMedia.Deleted;
        oldMedia.Attributes = newMedia.Attributes;
        ctx.SaveChanges();
        return oldMedia;
      }
    }

    public static int DeleteMedia(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Database.ExecuteSqlCommand("Delete From Media where Id = @p0", id);
      }
    }

    public static Media GetMediaById(this int id) {
      using (var ctx = new MyPhotosContainer()) {
        var items = from media in ctx.Media where (media.Id == id) select media;
        return items?.Include(media => media.Attributes).SingleOrDefault();
      }
    }

    public static List<Media> GetAllMedia() {
      using (var ctx = new MyPhotosContainer()) {
        return ctx.Media.Include("AttributeValues").ToList();
      }
    }
  }
}
