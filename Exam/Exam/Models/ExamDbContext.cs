using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TimetableApplication.Models;
using TimetableApplication.Models;
using System.Data.Linq;
#nullable disable

namespace Exam.Models
{
    public partial class ExamDBContext : DbContext
    {
        public ExamDBContext()
        {
        }

        public ExamDBContext(DbContextOptions<ExamDBContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Exam;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            
            modelBuilder.Entity<Dept>(entity =>
            {
                entity.ToTable("Dept");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");
                entity.Property(e => e.CourseName).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            
            
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.MiddleName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
              
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.Gender).HasMaxLength(50);
                entity.Property(e => e.EmailAddess).HasMaxLength(50);
                entity.Property(e => e.DateOfBirth).HasMaxLength(50);
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
