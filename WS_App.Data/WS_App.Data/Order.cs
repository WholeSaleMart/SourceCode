//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_App.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<int> SellerID { get; set; }
        public Nullable<int> DeliveryAddressID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> OrderAmt { get; set; }
        public Nullable<decimal> ShippingAmt { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> OrderDeliveryDate { get; set; }
        public string OrderStatus { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public string CreateUserID { get; set; }
    
        public virtual BusinessPerson BusinessPerson { get; set; }
        public virtual BusinessPerson BusinessPerson1 { get; set; }
        public virtual PersonAdress PersonAdress { get; set; }
        public virtual Product Product { get; set; }
    }
}
