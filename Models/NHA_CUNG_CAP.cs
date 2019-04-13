namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHA_CUNG_CAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHA_CUNG_CAP()
        {
            HOA_DON_NHAP = new HashSet<HOA_DON_NHAP>();
            MAT_HANG = new HashSet<MAT_HANG>();
        }

        [Key]
        [StringLength(10)]
        public string MANCC { get; set; }

        [StringLength(50)]
        public string TENNCC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON_NHAP> HOA_DON_NHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAT_HANG> MAT_HANG { get; set; }
    }
}
