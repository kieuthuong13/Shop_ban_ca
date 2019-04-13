namespace Shop_ban_ca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANG_NHAP
    {
        [Key]
        [StringLength(20)]
        public string TAIKHOAN { get; set; }

        [StringLength(20)]
        public string MATKHAU { get; set; }
    }
}
