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
    
    public partial class BusinessPerson
    {
        public BusinessPerson()
        {
            this.BusinessCategoryLinks = new HashSet<BusinessCategoryLink>();
            this.BusinessPinCodeLinks = new HashSet<BusinessPinCodeLink>();
            this.Products = new HashSet<Product>();
            this.Orders = new HashSet<Order>();
            this.Orders1 = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string BussinessType { get; set; }
        public Nullable<int> BussinesCategoryID { get; set; }
        public string BussinessName { get; set; }
        public string BusinessDetails { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string OtherNo { get; set; }
        public byte[] Logo { get; set; }
        public string LogoPath { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public string CreateUserID { get; set; }
    
        public virtual BusinessCategory BusinessCategory { get; set; }
        public virtual ICollection<BusinessCategoryLink> BusinessCategoryLinks { get; set; }
        public virtual ICollection<BusinessPinCodeLink> BusinessPinCodeLinks { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> Orders1 { get; set; }
    }
}