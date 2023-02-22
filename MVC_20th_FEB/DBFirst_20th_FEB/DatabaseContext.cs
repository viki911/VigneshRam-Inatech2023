using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Models
{
 

        public partial class DatabaseContext : DbContext
        {
            public DatabaseContext()
            {

            }

            public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
            {
             
            }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Db;Trusted_Connection=True;");

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Department>(entity =>
                {
                    entity.HasKey(e => e.DepartmentId).HasName("PK_DeptId");

                    entity.ToTable("Department");

                    entity.Property(e => e.DepartmentName)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<Employee>(entity =>
                {
                    entity.HasKey(e => e.EmployeeId).HasName("PK_Emp");

                    entity.ToTable("Employee");

                    entity.Property(e => e.DateofBirth).HasColumnType("date");
                    entity.Property(e => e.Designation)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                    entity.Property(e => e.EmpName)
                        .HasMaxLength(30)
                        .IsUnicode(false);
                    entity.Property(e => e.Gender)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.HasOne(d => d.Dept).WithMany(p => p.Employees)
                        .HasForeignKey(d => d.DeptId)
                        .HasConstraintName("FK_Emp");
                });

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
