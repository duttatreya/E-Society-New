//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resident
    {
        public int intercom { get; set; }
        public string hno { get; set; }
        public string resname { get; set; }
        public long contact { get; set; }
    
        public virtual House House { get; set; }
    }
}