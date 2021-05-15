using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Lab3DatabaseWinform.Models
{
    public partial class BokhandelContext : DbContext
    {
        public BokhandelContext()
        {
        }

        public BokhandelContext(DbContextOptions<BokhandelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Butiker> Butikers { get; set; }
        public virtual DbSet<Böcker> Böckers { get; set; }
        public virtual DbSet<Författare> Författares { get; set; }
        public virtual DbSet<Kunder> Kunders { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Bokhandel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.ToTable("Butiker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ButiksNamn)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Stad)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn13)
                    .HasName("PK__Böcker__3BF79E03681D50A1");

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn13)
                    .HasMaxLength(60)
                    .HasColumnName("ISBN13");

                entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

                entity.Property(e => e.Språk)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Utgivningsdatum).HasColumnType("date");

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.FörfattareId)
                    .HasConstraintName("FK__Böcker__Författa__25869641");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Födelsedatum)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Kunder>(entity =>
            {
                entity.ToTable("Kunder");

                entity.HasIndex(e => e.Personnr, "UQ__Kunder__AA2D1726C8943F77")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Personnr)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.Isbn13id, e.ButiksId })
                    .HasName("PK__LagerSal__1392EB57AE84EB4D");

                entity.ToTable("LagerSaldo");

                entity.Property(e => e.Isbn13id)
                    .HasMaxLength(60)
                    .HasColumnName("ISBN13ID");

                entity.Property(e => e.ButiksId).HasColumnName("ButiksID");

                entity.HasOne(d => d.Butiks)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.ButiksId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LagerSald__Butik__2B3F6F97");

                entity.HasOne(d => d.Isbn13)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.Isbn13id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LagerSald__ISBN1__2A4B4B5E");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.Property(e => e.KundId).HasColumnName("KundID");

                entity.HasOne(d => d.Butik)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ButikId)
                    .HasConstraintName("FK__Order__ButikID__31EC6D26");

                entity.HasOne(d => d.Kund)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.KundId)
                    .HasConstraintName("FK__Order__KundID__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
