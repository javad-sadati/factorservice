//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopCenter.Modal
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Product
    {
        public tbl_Product()
        {
            this.tbl_OrderDeatail = new HashSet<tbl_OrderDeatail>();
            this.tbl_Store = new HashSet<tbl_Store>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Barcode { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Note { get; set; }
    
        public virtual ICollection<tbl_OrderDeatail> tbl_OrderDeatail { get; set; }
        public virtual ICollection<tbl_Store> tbl_Store { get; set; }
    }
}
