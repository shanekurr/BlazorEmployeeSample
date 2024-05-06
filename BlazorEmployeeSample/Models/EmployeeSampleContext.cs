using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmployeeSample.Models;

public partial class EmployeeSampleContext : DbContext
{
    public EmployeeSampleContext()
    {
    }

    public EmployeeSampleContext(DbContextOptions<EmployeeSampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Employees");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AddressZip)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Employees");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
