using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThbLesson10EFDbFirst.Models;

public partial class Thblesson10EfContext : DbContext
{
    public Thblesson10EfContext()
    {
    }

    public Thblesson10EfContext(DbContextOptions<Thblesson10EfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ThbMember> ThbMembers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Thblesson10EF;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ThbMember>(entity =>
        {
            entity.ToTable("ThbMember");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ThbEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThbFullName).HasMaxLength(50);
            entity.Property(e => e.ThbPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThbPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThbUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
