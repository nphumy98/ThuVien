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
            modelBuilder.Entity<DocGia>()
                .HasKey(c => c.sMaDocGia);

            modelBuilder.Entity<Sach>()
                .HasKey(c => c.sMaSach);

            modelBuilder.Entity<ThuThu>()
                .HasKey(c => c.sMaNhanVien);

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
