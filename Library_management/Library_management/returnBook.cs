//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_management
{
    using System;
    using System.Collections.Generic;
    
    public partial class returnBook
    {
        public Nullable<int> uid { get; set; }
        public Nullable<int> bid { get; set; }
        public Nullable<bool> isExpired { get; set; }
        public Nullable<bool> isDamaged { get; set; }
        public Nullable<bool> isLost { get; set; }
        public Nullable<bool> pending { get; set; }
        public int id { get; set; }
    
        public virtual book book { get; set; }
        public virtual user user { get; set; }
    }
}
