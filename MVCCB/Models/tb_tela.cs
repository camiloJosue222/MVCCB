//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_tela
    {
        public decimal tela_id { get; set; }
        public string tela_desc { get; set; }
        public string tela_nom { get; set; }
        public Nullable<decimal> tipo_id { get; set; }
    
        public virtual tb_tipotela tb_tipotela { get; set; }
    }
}
