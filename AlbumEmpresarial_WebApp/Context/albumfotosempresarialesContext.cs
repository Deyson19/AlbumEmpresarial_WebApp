using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlbumEmpresarial_WebApp.Context
{
    public partial class albumfotosempresarialesContext : DbContext
    {
        public albumfotosempresarialesContext()
        {
        }

        public albumfotosempresarialesContext(DbContextOptions<albumfotosempresarialesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Foto> Fotos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Foto>(entity =>
            {
                entity.ToTable("fotos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DescripcionEvento)
                    .HasMaxLength(150)
                    .HasColumnName("descripcion_evento");

                entity.Property(e => e.FechaEvento)
                    .HasMaxLength(50)
                    .HasColumnName("fecha_evento");

                entity.Property(e => e.Imagen).HasColumnName("imagen");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(50)
                    .HasColumnName("lugar");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
