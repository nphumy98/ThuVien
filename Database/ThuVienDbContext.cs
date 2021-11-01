using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ThuVienDbContext : DbContext
    {
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TheMuon> TheMuons { get; set; }
        public DbSet<ThuThu> ThuThus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A7VMAJ8;Initial Catalog=QL_THUVIEN;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Doc gia
            modelBuilder.Entity<DocGia>()
                .HasKey(c => c.sMaDocGia);
           
            //Sach
            modelBuilder.Entity<Sach>()
                .HasKey(c => c.sMaSach);

            //Thu Thu
            modelBuilder.Entity<ThuThu>()
                .HasKey(c => c.sMaNhanVien);

            // Yeu Cau Sach
            modelBuilder.Entity<YeuCauSach>()
                .HasKey(c => c.sMaYeuCau);

            modelBuilder.Entity<YeuCauSach>()
                        .HasOne(sc => sc.sDocGia)
                        .WithMany(s => s.YeuCauSachs)
                        .HasForeignKey(sc => sc.sMaDocGia);

            modelBuilder.Entity<YeuCauSach>()
                        .HasOne(sc => sc.sSach)
                        .WithMany(s => s.YeuCauSachs)
                        .HasForeignKey(sc => sc.sMaSach);

            //The Muon
            modelBuilder.Entity<TheMuon>()
                .HasKey(c => c.sMaThe);

            modelBuilder.Entity<TheMuon>()
                        .HasOne(sc => sc.sDocGia)
                        .WithMany(s => s.TheMuons)
                        .HasForeignKey(sc => sc.sMaDocGia);

            modelBuilder.Entity<TheMuon>()
                        .HasOne(sc => sc.sSach)
                        .WithMany(s => s.TheMuons)
                        .HasForeignKey(sc => sc.sMaSach);

            modelBuilder.Entity<TheMuon>()
                        .HasOne(sc => sc.sNhanVien)
                        .WithMany(s => s.TheMuons)
                        .HasForeignKey(sc => sc.sMaNhanVien);
        }
    }
}
