using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BP2Bolnica.Models
{
    public partial class BP2BolnicaContext : DbContext
    {
        public BP2BolnicaContext()
        {
        }

        public BP2BolnicaContext(DbContextOptions<BP2BolnicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bolnica> Bolnicas { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Intervencija> Intervencijas { get; set; }
        public virtual DbSet<MedicinskiTehnicar> MedicinskiTehnicars { get; set; }
        public virtual DbSet<ObavljaPregled> ObavljaPregleds { get; set; }
        public virtual DbSet<Obezbedjenje> Obezbedjenjes { get; set; }
        public virtual DbSet<Odeljenje> Odeljenjes { get; set; }
        public virtual DbSet<OperacionaSala> OperacionaSalas { get; set; }
        public virtual DbSet<Pacijent> Pacijents { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<Spremacica> Spremacicas { get; set; }
        public virtual DbSet<Zaposleni> Zaposlenis { get; set; }
        public virtual DbSet<ZdravstveniRadnik> ZdravstveniRadniks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BP2BolnicaConnectionString"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bolnica>(entity =>
            {
                entity.HasKey(e => e.IdBolnice)
                    .HasName("PK__Bolnica__98340BD79A394466");

                entity.ToTable("Bolnica");

                entity.Property(e => e.IdBolnice).HasColumnName("idBolnice");

                entity.Property(e => e.NazivBolnice)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nazivBolnice");
            });

            modelBuilder.Entity<Doktor>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Doktor__F22F83F1F39608E2");

                entity.ToTable("Doktor");

                entity.Property(e => e.IdZaposlenog)
                    .ValueGeneratedNever()
                    .HasColumnName("idZaposlenog");

                entity.Property(e => e.Specijalizacija)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("specijalizacija");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithOne(p => p.Doktor)
                    .HasForeignKey<Doktor>(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doktor__idZaposl__6AEFE058");
            });

            modelBuilder.Entity<Intervencija>(entity =>
            {
                entity.HasKey(e => e.IdI)
                    .HasName("PK__Interven__DC501A27898BE66F");

                entity.ToTable("Intervencija");

                entity.Property(e => e.IdI).HasColumnName("idI");

                entity.Property(e => e.DatumI)
                    .HasColumnType("date")
                    .HasColumnName("datumI");

                entity.Property(e => e.IdOdeljenja).HasColumnName("idOdeljenja");

                entity.Property(e => e.IdP).HasColumnName("idP");

                entity.Property(e => e.IdZaposlenog).HasColumnName("idZaposlenog");

                entity.Property(e => e.RbSale).HasColumnName("rbSale");

                entity.Property(e => e.TrajanjeI).HasColumnName("trajanjeI");

                entity.Property(e => e.VremeI).HasColumnName("vremeI");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Intervencijas)
                    .HasForeignKey(d => new { d.IdZaposlenog, d.IdP })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Intervencija__7D0E9093");

                entity.HasOne(d => d.OperacionaSala)
                    .WithMany(p => p.Intervencijas)
                    .HasForeignKey(d => new { d.RbSale, d.IdOdeljenja })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Intervencija__7E02B4CC");
            });

            modelBuilder.Entity<MedicinskiTehnicar>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Medicins__F22F83F1C4BC71EC");

                entity.ToTable("MedicinskiTehnicar");

                entity.Property(e => e.IdZaposlenog)
                    .ValueGeneratedNever()
                    .HasColumnName("idZaposlenog");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithOne(p => p.MedicinskiTehnicar)
                    .HasForeignKey<MedicinskiTehnicar>(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicinsk__idZap__6DCC4D03");
            });

            modelBuilder.Entity<ObavljaPregled>(entity =>
            {
                entity.HasKey(e => new { e.IdZaposlenog, e.IdP })
                    .HasName("PK__ObavljaP__EFEA8253B346797A");

                entity.ToTable("ObavljaPregled");

                entity.Property(e => e.IdZaposlenog).HasColumnName("idZaposlenog");

                entity.Property(e => e.IdP).HasColumnName("idP");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany(p => p.ObavljaPregleds)
                    .HasForeignKey(d => d.IdP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ObavljaPreg__idP__7755B73D");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithMany(p => p.ObavljaPregleds)
                    .HasForeignKey(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ObavljaPr__idZap__76619304");
            });

            modelBuilder.Entity<Obezbedjenje>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Obezbedj__F22F83F1A4E4D313");

                entity.ToTable("Obezbedjenje");

                entity.Property(e => e.IdZaposlenog)
                    .ValueGeneratedNever()
                    .HasColumnName("idZaposlenog");

                entity.Property(e => e.DozvolaZaOruzje).HasColumnName("dozvolaZaOruzje");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithOne(p => p.Obezbedjenje)
                    .HasForeignKey<Obezbedjenje>(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Obezbedje__idZap__625A9A57");
            });

            modelBuilder.Entity<Odeljenje>(entity =>
            {
                entity.HasKey(e => e.IdOdeljenja)
                    .HasName("PK__Odeljenj__B6A9C0731353DE97");

                entity.ToTable("Odeljenje");

                entity.Property(e => e.IdOdeljenja).HasColumnName("idOdeljenja");

                entity.Property(e => e.NazivOdeljenja)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nazivOdeljenja");

                entity.Property(e => e.Sprat).HasColumnName("sprat");
            });

            modelBuilder.Entity<OperacionaSala>(entity =>
            {
                entity.HasKey(e => new { e.RbSale, e.IdOdeljenja })
                    .HasName("PK__Operacio__6294202819E11726");

                entity.ToTable("OperacionaSala");

                entity.Property(e => e.RbSale)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rbSale");

                entity.Property(e => e.IdOdeljenja).HasColumnName("idOdeljenja");

                entity.Property(e => e.ImaXray).HasColumnName("imaXray");

                entity.Property(e => e.NazivSale)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nazivSale");

                entity.Property(e => e.Sprat).HasColumnName("sprat");

                entity.HasOne(d => d.IdOdeljenjaNavigation)
                    .WithMany(p => p.OperacionaSalas)
                    .HasForeignKey(d => d.IdOdeljenja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Operacion__idOde__7A3223E8");
            });

            modelBuilder.Entity<Pacijent>(entity =>
            {
                entity.HasKey(e => e.BrojZdrKnjiz)
                    .HasName("PK__Pacijent__C303255054FDC5D5");

                entity.ToTable("Pacijent");

                entity.Property(e => e.BrojZdrKnjiz)
                    .ValueGeneratedNever()
                    .HasColumnName("brojZdrKnjiz");

                entity.Property(e => e.ImeP)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imeP");

                entity.Property(e => e.JmbgP)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jmbgP");

                entity.Property(e => e.PrezimeP)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("prezimeP");
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PK__Pregled__DC501A20DB6609F6");

                entity.ToTable("Pregled");

                entity.Property(e => e.IdP).HasColumnName("idP");

                entity.Property(e => e.BrojZdrKnjiz).HasColumnName("brojZdrKnjiz");

                entity.Property(e => e.DatumP)
                    .HasColumnType("date")
                    .HasColumnName("datumP");

                entity.Property(e => e.IdZaposlenog).HasColumnName("idZaposlenog");

                entity.Property(e => e.VremeP).HasColumnName("vremeP");

                entity.HasOne(d => d.BrojZdrKnjizNavigation)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.BrojZdrKnjiz)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pregled__brojZdr__72910220");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pregled__idZapos__73852659");
            });

            modelBuilder.Entity<Spremacica>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Spremaci__F22F83F16EF41545");

                entity.ToTable("Spremacica");

                entity.Property(e => e.IdZaposlenog)
                    .ValueGeneratedNever()
                    .HasColumnName("idZaposlenog");

                entity.Property(e => e.IdOdeljenja).HasColumnName("idOdeljenja");

                entity.HasOne(d => d.IdOdeljenjaNavigation)
                    .WithMany(p => p.Spremacicas)
                    .HasForeignKey(d => d.IdOdeljenja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Spremacic__idOde__681373AD");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithOne(p => p.Spremacica)
                    .HasForeignKey<Spremacica>(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Spremacic__idZap__671F4F74");
            });

            modelBuilder.Entity<Zaposleni>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Zaposlen__F22F83F14DA46FB4");

                entity.ToTable("Zaposleni");

                entity.Property(e => e.IdZaposlenog).HasColumnName("idZaposlenog");

                entity.Property(e => e.IdBolnice).HasColumnName("idBolnice");

                entity.Property(e => e.ImeZ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imeZ");

                entity.Property(e => e.JmbgZ)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jmbgZ");

                entity.Property(e => e.PlataZ).HasColumnName("plataZ");

                entity.Property(e => e.PrezimeZ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("prezimeZ");

                entity.Property(e => e.TipZaposlenog)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipZaposlenog");

                entity.HasOne(d => d.IdBolniceNavigation)
                    .WithMany(p => p.Zaposlenis)
                    .HasForeignKey(d => d.IdBolnice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Zaposleni__idBol__5CA1C101");
            });

            modelBuilder.Entity<ZdravstveniRadnik>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenog)
                    .HasName("PK__Zdravstv__F22F83F1CA54A146");

                entity.ToTable("ZdravstveniRadnik");

                entity.Property(e => e.IdZaposlenog)
                    .ValueGeneratedNever()
                    .HasColumnName("idZaposlenog");

                entity.Property(e => e.BrojLicence).HasColumnName("brojLicence");

                entity.Property(e => e.TipZdrRad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipZdrRad");

                entity.HasOne(d => d.IdZaposlenogNavigation)
                    .WithOne(p => p.ZdravstveniRadnik)
                    .HasForeignKey<ZdravstveniRadnik>(d => d.IdZaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Zdravstve__idZap__5F7E2DAC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
