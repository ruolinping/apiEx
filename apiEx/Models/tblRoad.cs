//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiEx.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRoad()
        {
            this.tblTransactions = new HashSet<tblTransaction>();
        }
    
        public int BIA_No { get; set; }
        public string Road_Name { get; set; }
        public Nullable<int> Type_Id { get; set; }
        public Nullable<double> Miles { get; set; }
    
        public virtual tblType tblType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
