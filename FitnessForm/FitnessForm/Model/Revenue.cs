//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessForm.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revenue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revenue()
        {
            this.NetRevenues = new HashSet<NetRevenue>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PriceId { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NetRevenue> NetRevenues { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}