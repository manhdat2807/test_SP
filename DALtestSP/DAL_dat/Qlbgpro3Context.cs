using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DALtestSP.DAL_dat;

public partial class Qlbgpro3Context : DbContext
{
    public Qlbgpro3Context()
    {
    }

    public Qlbgpro3Context(DbContextOptions<Qlbgpro3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cthd> Cthds { get; set; }

    public virtual DbSet<Ctsp> Ctsps { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Xuatxu> Xuatxus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-CBS83PCK\\SQLEXPRESS  ;Initial Catalog=QLBGPRO3;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cthd>(entity =>
        {
            entity.HasKey(e => e.MaCthd).HasName("PK__CTHD__1E4FA7711F4D9D8A");

            entity.ToTable("CTHD");

            entity.Property(e => e.MaCthd)
                .HasMaxLength(10)
                .HasColumnName("MaCTHD");
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.Manv).HasMaxLength(10);
            entity.Property(e => e.Masp).HasMaxLength(10);
            entity.Property(e => e.Soluong).HasColumnName("soluong");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__MaHD__52593CB8");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__Manv__534D60F1");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__Masp__5441852A");
        });

        modelBuilder.Entity<Ctsp>(entity =>
        {
            entity.HasKey(e => e.MaCtsp).HasName("PK__CTSP__3FEC9084BA925DC7");

            entity.ToTable("CTSP");

            entity.Property(e => e.MaCtsp)
                .HasMaxLength(10)
                .HasColumnName("Ma_CTSP");
            entity.Property(e => e.MaMs).HasMaxLength(10);
            entity.Property(e => e.MaSize).HasMaxLength(10);
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .HasColumnName("MaSP");
            entity.Property(e => e.MaTh)
                .HasMaxLength(10)
                .HasColumnName("MaTH");
            entity.Property(e => e.MaXx)
                .HasMaxLength(10)
                .HasColumnName("MaXX");

            entity.HasOne(d => d.MaMsNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.MaMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__MaMs__4222D4EF");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.MaSize)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__MaSize__440B1D61");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__MaSP__412EB0B6");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.MaTh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__MaTH__4316F928");

            entity.HasOne(d => d.MaXxNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.MaXx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__MaXX__44FF419A");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__Hoadon__2725A6E078200CF4");

            entity.ToTable("Hoadon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.MaKm)
                .HasMaxLength(10)
                .HasColumnName("MaKM");
            entity.Property(e => e.Manv).HasMaxLength(10);
            entity.Property(e => e.Ngaymua)
                .HasColumnType("datetime")
                .HasColumnName("ngaymua");
            entity.Property(e => e.Thanhtien).HasColumnName("thanhtien");

            entity.HasOne(d => d.MaKmNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaKm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hoadon__MaKM__4F7CD00D");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hoadon__Manv__4E88ABD4");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.MaKm).HasName("PK__Khuyenma__2725CF15A68BCB39");

            entity.ToTable("Khuyenmai");

            entity.Property(e => e.MaKm)
                .HasMaxLength(10)
                .HasColumnName("MaKM");
            entity.Property(e => e.Ngaydung)
                .HasColumnType("datetime")
                .HasColumnName("ngaydung");
            entity.Property(e => e.Ngaykt)
                .HasColumnType("datetime")
                .HasColumnName("ngaykt");
            entity.Property(e => e.Ngaytao).HasColumnType("datetime");
            entity.Property(e => e.Phantramgiam)
                .HasMaxLength(10)
                .HasColumnName("phantramgiam");
            entity.Property(e => e.Tenkm)
                .HasMaxLength(90)
                .HasColumnName("tenkm");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__Kichco__A787E7ED7873B8C0");

            entity.ToTable("Kichco");

            entity.Property(e => e.MaSize).HasMaxLength(10);
            entity.Property(e => e.Kichco1).HasColumnName("Kichco");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.MaMs).HasName("PK__Mausac__2725DFD6448C05FA");

            entity.ToTable("Mausac");

            entity.Property(e => e.MaMs)
                .HasMaxLength(10)
                .HasColumnName("MaMS");
            entity.Property(e => e.TenMs)
                .HasMaxLength(50)
                .HasColumnName("tenMS");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__Nhanvien__2724CB02B24B2B75");

            entity.ToTable("Nhanvien");

            entity.Property(e => e.Manv).HasMaxLength(10);
            entity.Property(e => e.Diachi)
                .HasMaxLength(90)
                .HasColumnName("diachi");
            entity.Property(e => e.MaTk)
                .HasMaxLength(10)
                .HasColumnName("MaTK");
            entity.Property(e => e.Ngaysinh).HasColumnType("datetime");
            entity.Property(e => e.Tennv)
                .HasMaxLength(50)
                .HasColumnName("tennv");
            entity.Property(e => e.Vaitro)
                .HasMaxLength(50)
                .HasColumnName("vaitro");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.MaTk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Nhanvien__MaTK__4BAC3F29");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__Sanpham__27240C24D3B2F6E3");

            entity.ToTable("Sanpham");

            entity.Property(e => e.Masp).HasMaxLength(10);
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.Tensp).HasMaxLength(50);
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__Taikhoan__272500709701418C");

            entity.ToTable("Taikhoan");

            entity.Property(e => e.MaTk)
                .HasMaxLength(10)
                .HasColumnName("MaTK");
            entity.Property(e => e.Passwords)
                .HasMaxLength(20)
                .HasColumnName("passwords");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.MaTh).HasName("PK__Thuonghi__272500757C9401E6");

            entity.ToTable("Thuonghieu");

            entity.Property(e => e.MaTh)
                .HasMaxLength(10)
                .HasColumnName("MaTH");
            entity.Property(e => e.TenTh)
                .HasMaxLength(50)
                .HasColumnName("tenTH");
        });

        modelBuilder.Entity<Xuatxu>(entity =>
        {
            entity.HasKey(e => e.MaXx).HasName("PK__Xuatxu__272520C0643DEE7B");

            entity.ToTable("Xuatxu");

            entity.Property(e => e.MaXx)
                .HasMaxLength(10)
                .HasColumnName("MaXX");
            entity.Property(e => e.TennoiXx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TennoiXX");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
