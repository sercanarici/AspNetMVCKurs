//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alcom.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunKategori
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public int UrunId { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        public virtual Urun Urun { get; set; }
    }
}