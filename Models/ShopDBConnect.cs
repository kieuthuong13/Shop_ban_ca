namespace Shop_ban_ca.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDBConnect : DbContext
    {
        public ShopDBConnect()
            : base("name=Model11")
        {
        }

        public virtual DbSet<CHI_TIET_DATHANG> CHI_TIET_DATHANG { get; set; }
        public virtual DbSet<CHI_TIET_HDN> CHI_TIET_HDN { get; set; }
        public virtual DbSet<CHI_TIET_HDX> CHI_TIET_HDX { get; set; }
        public virtual DbSet<DANG_NHAP> DANG_NHAP { get; set; }
        public virtual DbSet<DAT_HANG> DAT_HANG { get; set; }
        public virtual DbSet<HOA_DON_NHAP> HOA_DON_NHAP { get; set; }
        public virtual DbSet<HOA_DON_XUAT> HOA_DON_XUAT { get; set; }
        public virtual DbSet<LOAI_MAT_HANG> LOAI_MAT_HANG { get; set; }
        public virtual DbSet<MAT_HANG> MAT_HANG { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_DATHANG>()
                .Property(e => e.MAPHIEU)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_DATHANG>()
                .Property(e => e.MAMATHANG)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_DATHANG>()
                .Property(e => e.SOLUONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CHI_TIET_HDN>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDN>()
                .Property(e => e.MAMATHANG)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDN>()
                .Property(e => e.SOLUONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CHI_TIET_HDN>()
                .Property(e => e.DVT)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDN>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHI_TIET_HDX>()
                .Property(e => e.MAMATHANG)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDX>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDX>()
                .Property(e => e.SOLUONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CHI_TIET_HDX>()
                .Property(e => e.DVT)
                .IsFixedLength();

            modelBuilder.Entity<CHI_TIET_HDX>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DANG_NHAP>()
                .Property(e => e.TAIKHOAN)
                .IsFixedLength();

            modelBuilder.Entity<DANG_NHAP>()
                .Property(e => e.MATKHAU)
                .IsFixedLength();

            modelBuilder.Entity<DAT_HANG>()
                .Property(e => e.MAPHIEU)
                .IsFixedLength();

            modelBuilder.Entity<DAT_HANG>()
                .Property(e => e.SDT)
                .HasPrecision(11, 0);

            modelBuilder.Entity<DAT_HANG>()
                .HasMany(e => e.CHI_TIET_DATHANG)
                .WithRequired(e => e.DAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON_NHAP>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON_NHAP>()
                .Property(e => e.MANCC)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON_NHAP>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON_NHAP>()
                .Property(e => e.GHICHU)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON_NHAP>()
                .HasMany(e => e.CHI_TIET_HDN)
                .WithRequired(e => e.HOA_DON_NHAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON_XUAT>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON_XUAT>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<HOA_DON_XUAT>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON_XUAT>()
                .HasMany(e => e.CHI_TIET_HDX)
                .WithRequired(e => e.HOA_DON_XUAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAI_MAT_HANG>()
                .Property(e => e.MALOAI)
                .IsFixedLength();

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.MAMATHANG)
                .IsFixedLength();

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.SOLUONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.MANCC)
                .IsFixedLength();

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.MALOAI)
                .IsFixedLength();

            modelBuilder.Entity<MAT_HANG>()
                .HasMany(e => e.CHI_TIET_DATHANG)
                .WithRequired(e => e.MAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAT_HANG>()
                .HasMany(e => e.CHI_TIET_HDN)
                .WithRequired(e => e.MAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAT_HANG>()
                .HasMany(e => e.CHI_TIET_HDX)
                .WithRequired(e => e.MAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHA_CUNG_CAP>()
                .Property(e => e.MANCC)
                .IsFixedLength();

            modelBuilder.Entity<NHA_CUNG_CAP>()
                .Property(e => e.SDT)
                .HasPrecision(11, 0);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SDT)
                .HasPrecision(11, 0);
        }
    }
}
