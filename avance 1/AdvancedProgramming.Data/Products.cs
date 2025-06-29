//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvancedProgramming.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> InventoryID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
