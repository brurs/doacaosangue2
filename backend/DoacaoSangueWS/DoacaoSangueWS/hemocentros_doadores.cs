//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoacaoSangueWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class hemocentros_doadores
    {
        public int id { get; set; }
        public int id_doador { get; set; }
        public int id_hemocentro { get; set; }
    
        public virtual doadores doadores { get; set; }
        public virtual hemocentros hemocentros { get; set; }
    }
}