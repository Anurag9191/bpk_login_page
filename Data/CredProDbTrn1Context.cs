using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RegUserinCredproMVC.Models;

namespace RegUserinCredproMVC.Data;

public partial class CredProDbTrn1Context : DbContext
{
    public CredProDbTrn1Context()
    {
    }

   
    public CredProDbTrn1Context(DbContextOptions<CredProDbTrn1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<RegUser> RegUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      => optionsBuilder.UseSqlServer("Data Source=68.178.161.197;Initial Catalog=CredProDB_TRN1;User ID=TRNUSR1;Password=Trn@#23;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RegUsers__3214EC078DF607A1");

            entity.Property(e => e.ConfirmPassword).HasMaxLength(255);
            entity.Property(e => e.DigitalSignature).HasMaxLength(500);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Fname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HashPassword).HasMaxLength(255);
            entity.Property(e => e.Lname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Mname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MName");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Pin).HasMaxLength(10);
            entity.Property(e => e.ProfilePhoto).HasMaxLength(500);
            entity.Property(e => e.UserAddress).HasMaxLength(400);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
