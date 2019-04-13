namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_DATHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAPHIEU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAMATHANG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SOLUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAN { get; set; }

        public virtual DAT_HANG DAT_HANG { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }
    }
}
