namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAT_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAT_HANG()
        {
            CHI_TIET_DATHANG = new HashSet<CHI_TIET_DATHANG>();
            CHI_TIET_HDN = new HashSet<CHI_TIET_HDN>();
            CHI_TIET_HDX = new HashSet<CHI_TIET_HDX>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã mặt hàng")]
        public string MAMATHANG { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên mặt hàng")]
        public string TENMATHANG { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Số lượng")]
        public decimal? SOLUONG { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Đơn giá")]
        public decimal? DONGIA { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã nhà cung cấp")]
        public string MANCC { get; set; }

        [StringLength(10)]
        [Display(Name = "Loại")]
        public string MALOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_DATHANG> CHI_TIET_DATHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HDN> CHI_TIET_HDN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HDX> CHI_TIET_HDX { get; set; }

        public virtual LOAI_MAT_HANG LOAI_MAT_HANG { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }
    }
}
