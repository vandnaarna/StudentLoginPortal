using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentLoginPortal.Models;

public partial class DemoMvcContext : DbContext
{
    public DemoMvcContext()
    {
    }

    public DemoMvcContext(DbContextOptions<DemoMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentDetail> StudentDetails { get; set; }

    public virtual DbSet<StudentHobby> StudentHobbies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S4GDDSI;Database=DemoMVC;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity.ToTable("StudentDetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Class)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                 .HasMaxLength(10)
                 .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentHobby>(entity =>
        {
            entity.HasKey(e => e.Hid);

            entity.ToTable("StudentHobby");

            entity.Property(e => e.Hobby)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
