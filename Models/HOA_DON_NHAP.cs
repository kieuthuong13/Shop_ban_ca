namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON_NHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON_NHAP()
        {
            CHI_TIET_HDN = new HashSet<CHI_TIET_HDN>();
        }

        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [StringLength(10)]
        public string MANCC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [StringLength(10)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HDN> CHI_TIET_HDN { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }
    }
}
