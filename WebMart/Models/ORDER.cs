//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMart.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int OrderUnit { get; set; }
        public decimal OrderAmount { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
