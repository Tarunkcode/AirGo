using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AirGo.Services.airlines
{
    public partial class AirlinesContext : DbContext
    {
        public AirlinesContext()
        {
        }

        public AirlinesContext(DbContextOptions<AirlinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirTicket> AirTickets { get; set; }
        public virtual DbSet<FlightTiming> FlightTimings { get; set; }
        public virtual DbSet<IfConfirmed> IfConfirmeds { get; set; }
        public virtual DbSet<PassangerDetail> PassangerDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ESLAPIT2\\SQL2019;Database=Airlines;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirTicket>(entity =>
            {
                entity.HasKey(e => e.RefId)
                    .HasName("PK__AirTicke__198D51D519B555AD");

                entity.Property(e => e.RefId).HasColumnName("refId");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.ModelNo).HasColumnName("modelNo");

                entity.Property(e => e.PassangerId).HasColumnName("passangerId");

                entity.Property(e => e.PilotName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pilotName");

                entity.Property(e => e.RequestNo).HasColumnName("requestNo");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.AirTickets)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AirTicket__fligh__3F466844");

                entity.HasOne(d => d.Passanger)
                    .WithMany(p => p.AirTickets)
                    .HasForeignKey(d => d.PassangerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AirTicket__passa__3E52440B");

                entity.HasOne(d => d.RequestNoNavigation)
                    .WithMany(p => p.AirTickets)
                    .HasForeignKey(d => d.RequestNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AirTicket__reque__403A8C7D");
            });

            modelBuilder.Entity<FlightTiming>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__FlightTi__D9F8227C231848F8");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FlightName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnName("inTime");

                entity.Property(e => e.OutTime).HasColumnName("outTime");
            });

            modelBuilder.Entity<IfConfirmed>(entity =>
            {
                entity.HasKey(e => e.CN)
                    .HasName("PK__IfConfir__32136658FD4389C2");

                entity.ToTable("IfConfirmed");

                entity.Property(e => e.CN).HasColumnName("cN");

                entity.Property(e => e.IfDeclined)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ifDeclined");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<PassangerDetail>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Passange__DD36D56287E6625F");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.PAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pAddress");

                entity.Property(e => e.PassangerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
