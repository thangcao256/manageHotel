using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKS.Database
{
    public partial class QLKSContextDB : DbContext
    {
        public QLKSContextDB()
            : base("name=QLKSContextDB8")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADON { get; set; }
        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONG { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.id_DV)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.id_DV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.id_KH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.id_P)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.id_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.ngaysinh)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.id_LP)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.id_P)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.id_LP)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.id_TK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.matkhau_TK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.sdt)
                .IsUnicode(false);
        }
    }
}
