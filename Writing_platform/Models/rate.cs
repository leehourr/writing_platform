//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Writing_platform.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rate
    {
        public int id { get; set; }
        public int uid { get; set; }
        public int work_id { get; set; }
        public Nullable<int> rating { get; set; }
    
        public virtual user user { get; set; }
        public virtual work work { get; set; }
    }
}
