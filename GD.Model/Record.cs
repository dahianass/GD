//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int IdRecord { get; set; }
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public int IdCheckProcess { get; set; }
        public int IdExpedient { get; set; }
        public string Observation { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Expedient Expedient { get; set; }
    }
}
