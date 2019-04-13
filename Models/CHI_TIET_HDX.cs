namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_HDX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAMATHANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SOLUONG { get; set; }

        [StringLength(10)]
        public string DVT { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        public virtual HOA_DON_XUAT HOA_DON_XUAT { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }
    }
}
