namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON_XUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON_XUAT()
        {
            CHI_TIET_HDX = new HashSet<CHI_TIET_HDX>();
        }

        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYXUAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HDX> CHI_TIET_HDX { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
