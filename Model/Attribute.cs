//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos {
  using System;
  using System.Collections.Generic;
  using System.Runtime.Serialization;

  [DataContract(IsReference = true)]
  public partial class Attribute {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Attribute() {
      this.Values = new HashSet<AttributeValue>();
    }

    [DataMember] public int Id { get; set; }
    [DataMember] public string Name { get; set; }
    [DataMember] public AttributeType Type { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    [DataMember] public virtual ICollection<AttributeValue> Values { get; set; }
  }
}
