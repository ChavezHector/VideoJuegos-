//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.VideoJuegos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.ProductoConsola = new HashSet<ProductoConsola>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int Existencia { get; set; }
        public int CodigoCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ProductoConsola> ProductoConsola { get; set; }
    }
}
