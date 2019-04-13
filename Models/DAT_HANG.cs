namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAT_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAT_HANG()
        {
            CHI_TIET_DATHANG = new HashSet<CHI_TIET_DATHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHIEU { get; set; }

        [StringLength(50)]
        public string TENKHACHHANG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDT { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_DATHANG> CHI_TIET_DATHANG { get; set; }
    }
}
