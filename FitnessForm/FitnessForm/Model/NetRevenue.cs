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
    
    public partial class NetRevenue
    {
        public int Id { get; set; }
        public Nullable<int> RevenueId { get; set; }
        public Nullable<int> ExpensesId { get; set; }
    
        public virtual Expens Expens { get; set; }
        public virtual Revenue Revenue { get; set; }
    }
}