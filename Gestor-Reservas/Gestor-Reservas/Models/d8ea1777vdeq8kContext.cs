using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class d8ea1777vdeq8kContext : DbContext
    {
        public d8ea1777vdeq8kContext()
        {
        }

        public d8ea1777vdeq8kContext(DbContextOptions<d8ea1777vdeq8kContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bloqueo> Bloqueos { get; set; }
        public virtual DbSet<OrigenReserva> OrigenReservas { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=ec2-52-201-124-168.compute-1.amazonaws.com; port=5432; user id = wvyaglaqcauppz; password = 72fc93432b36a92ca966f36292e03e943bfa51a687080994e21a77de023818f6; database=d8ea1777vdeq8k; pooling = true; SSL Mode=Prefer;Trust Server Certificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Bloqueo>(entity =>
            {
                entity.HasKey(e => e.IdBloqueo)
                    .HasName("bloqueos_pk");

                entity.ToTable("bloqueos");

                entity.Property(e => e.IdBloqueo)
                    .HasColumnName("id_bloqueo")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Egreso)
                    .HasColumnType("date")
                    .HasColumnName("egreso");

                entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");

                entity.Property(e => e.Ingreso)
                    .HasColumnType("date")
                    .HasColumnName("ingreso");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasColumnName("observaciones");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.Bloqueos)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bloqueos_unidades");
            });

            modelBuilder.Entity<OrigenReserva>(entity =>
            {
                entity.HasKey(e => e.IdOrigen)
                    .HasName("origen_reserva_pk");

                entity.ToTable("origen_reserva");

                entity.Property(e => e.IdOrigen)
                    .HasColumnName("id_origen")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .HasColumnName("origen");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("reservas_pk");

                entity.ToTable("reservas");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("id_reserva")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.CantidadAcompaniantes).HasColumnName("cantidad_acompaniantes");

                entity.Property(e => e.Cochera).HasColumnName("cochera");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dni");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Egreso)
                    .HasColumnType("date")
                    .HasColumnName("egreso");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");

                entity.Property(e => e.Ingreso)
                    .HasColumnType("date")
                    .HasColumnName("ingreso");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("localidad");

                entity.Property(e => e.MontoTotal).HasColumnName("monto_total");

                entity.Property(e => e.Noches).HasColumnName("noches");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.Senia).HasColumnName("senia");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdOrigenNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservas_origen_reserva");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservas_unidades");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidad)
                    .HasName("unidades_pk");

                entity.ToTable("unidades");

                entity.Property(e => e.IdUnidad)
                    .HasColumnName("id_unidad")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("usuarios_pk");

                entity.ToTable("usuarios");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
