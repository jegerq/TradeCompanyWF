//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeCompany.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFeedback
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int good_id { get; set; }
        public string text { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual tblGood tblGood { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
