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
    
    public partial class Country
    {
        public Country()
        {
            this.States = new HashSet<State>();
        }
    
        public int ID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public string CreateUserID { get; set; }
    
        public virtual ICollection<State> States { get; set; }
    }
}
