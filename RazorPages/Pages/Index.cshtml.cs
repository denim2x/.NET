using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferenceMyPhotos;
using RazorPages.Models;

namespace RazorPages.Pages {
  public class IndexModel : PageModel {
    private readonly ILogger<IndexModel> _logger;
    public List<MediaDTO> Media { get; set; }
    MyPhotosClient client = new MyPhotosClient();

    public IndexModel(ILogger<IndexModel> logger) {
      _logger = logger;
      Media = new List<MediaDTO>();
    }

    public async Task OnPostAsync(string Attribute, string Value) {
      var media = await client.GetAllMediaAsync();
      foreach (var item in media) {
        var md = new MediaDTO();
        md.Id = item.Id;
        md.Deleted = item.Deleted;
        var matched = false;
        foreach (var attr in item.Attributes) {
          var ad = new AttributeValueDTO();
          ad.MediaId = attr.MediaId;
          ad.AttributeId = attr.AttributeId;
          ad.Value = attr.Value;
          md.Attributes.Add(ad);
          if (Attribute != null && attr.Attribute.Name != Attribute)
            continue;

          if (Value != null && attr.Value != Value)
            continue;

          matched = true;
        }
        if (matched) {
          Media.Add(md);
        }
      }
    }

    public async Task OnGetAsync() {
      await OnPostAsync(null, null);
    }
  }
}
