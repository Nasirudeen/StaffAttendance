using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StaffAttendanceApps.Models;
//using System.Data.Linq;
#nullable disable

namespace StaffAttendanceApps.Models
{
    public partial class StaffDBContext : DbContext
    {
        public StaffDBContext()
        {
        }

        public StaffDBContext(DbContextOptions<StaffDBContext> options)
            : base(options)
        {
        }
        
       
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<StaffLevel> StaffLevels { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=StaffAttendance;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffLevel>(entity =>
            {
                entity.ToTable("StaffLevel");
                entity.Property(e => e.StaffLevelName).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.StaffNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StaffLevel).HasMaxLength(50);
                entity.Property(e => e.TimeIn).HasColumnType("datetime");
                entity.Property(e => e.TimeOut).HasColumnType("datetime");
                entity.Property(e => e.isLoggedIn).HasColumnType("50");
                entity.Property(e => e.isLoggedOut).HasColumnType("50");
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            
            
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.EmailAddress).HasMaxLength(50);
                entity.Property(e => e.Password).HasMaxLength(50);
                entity.Property(e => e.RoleId).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
