using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models {
  public class MediaDTO {
    public int Id { get; set; }
    public bool Deleted { get; set; }
    public List<AttributeValueDTO> Attributes { get; set; }

    public MediaDTO() {
      Deleted = false;
      Attributes = new List<AttributeValueDTO>();
    }
  }
}
