using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StartersApplication.Models;

namespace StartersApplication.DbContexts
{
    public partial class DoctorApponitmentDBContext : DbContext
    {
        public DoctorApponitmentDBContext()
        {
        }

        public DoctorApponitmentDBContext(DbContextOptions<DoctorApponitmentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<TblAppError> TblAppErrors { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Dhivya-Pc\\Sqlexpress;Database=DoctorApponitmentDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("confirmPassword")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength();

                entity.Property(e => e.Sanswer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SAnswer")
                    .IsFixedLength();

                entity.Property(e => e.Squestion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SQuestion")
                    .IsFixedLength();

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientHistory)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAppError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK__TblAppEr__358565CAD0DC078E");

                entity.Property(e => e.ErrorId).HasColumnName("ErrorID");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__1788CCACDE96E624");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
