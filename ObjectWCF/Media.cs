using MyPhotos;
using System.Collections.Generic;
using Global = MyPhotos;

namespace ObjectWCF {
  public partial class MyPhotos : IMyPhotos {    
    public bool AddMedia(Media media) {
      return media.AddMedia();
    }

    public int DeleteMedia(int id) {
      return id.DeleteMedia();
    }

    public List<Media> GetAllMedia() {
      return API.GetAllMedia();
    }


    public Media GetMediaById(int id) {
      return id.GetMediaById();
    }

    public Media UpdateMedia(Media media) {
      return media.UpdateMedia();
    }
  }
}
