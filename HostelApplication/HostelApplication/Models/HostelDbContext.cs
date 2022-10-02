using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HostelApplication.Models;

//using System.Data.Linq;
#nullable disable

namespace HostelApplication.Models
{
    public partial class HostelDbContext : DbContext
    {
        public HostelDbContext()
        {
        }

        public HostelDbContext(DbContextOptions<HostelDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<Absent> Absents { get; set; }
        public virtual DbSet<Bunk> Bunks { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<HallAdmin> HallAdmins { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Faculty> Facultys { get; set; }
       
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Exit> Exits { get; set; }
        public virtual DbSet<Relocate> Relocates { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Entry> Entrys { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Temporary> Temporarys { get; set; }
        //public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=HostelApps;Trusted_Connection=True;MultipleActiveResultSets=true");
            }  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.ToTable("AuditTrail");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.NewValue).HasMaxLength(50);

                entity.Property(e => e.ObjectName).HasMaxLength(50);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Allocation>(entity =>
            {
                entity.ToTable("Allocation");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);               
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.Hall).HasMaxLength(50);
                entity.Property(e => e.Block).HasMaxLength(50);
                entity.Property(e => e.Room).HasMaxLength(50);
                entity.Property(e => e.Bunk).HasMaxLength(50);
                entity.Property(e => e.StartDate).HasMaxLength(50);
                entity.Property(e => e.ExpireDate).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Relocate>(entity =>
            {
                entity.ToTable("Relocate");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.Hall).HasMaxLength(50);
                entity.Property(e => e.Block).HasMaxLength(50);
                entity.Property(e => e.Room).HasMaxLength(50);
                entity.Property(e => e.Bunk).HasMaxLength(50);
                entity.Property(e => e.StartDate).HasMaxLength(50);
                entity.Property(e => e.ExpireDate).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Temporary>(entity =>
            {
                entity.ToTable("Temporary");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.Hall).HasMaxLength(50);
                entity.Property(e => e.Block).HasMaxLength(50);
                entity.Property(e => e.Room).HasMaxLength(50);
                entity.Property(e => e.Bunk).HasMaxLength(50);
                entity.Property(e => e.StartDate).HasMaxLength(50);
                entity.Property(e => e.ExpireDate).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Absent>(entity =>
            {
                entity.ToTable("Absent");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
                entity.Property(e => e.EmailAddress).HasMaxLength(50);
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.DepartureDate).HasMaxLength(50);
                entity.Property(e => e.Destination).HasMaxLength(50);
                entity.Property(e => e.Parent).HasMaxLength(50);
                entity.Property(e => e.SessionofAdmission).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Block>(entity =>
            {
                entity.ToTable("Block");

                entity.Property(e => e.BlockNo).HasMaxLength(50);

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
            modelBuilder.Entity<Bunk>(entity =>
            {
                entity.ToTable("Bunk");

                entity.Property(e => e.BunkNo).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            modelBuilder.Entity<Hall>(entity =>
            {
                entity.ToTable("Hall");

                entity.Property(e => e.HallName).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

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
            modelBuilder.Entity<HallAdmin>(entity =>
            {
                entity.ToTable("HallAdmin");

                entity.Property(e => e.Title).HasMaxLength(50);
                entity.Property(e => e.HallAdminName).HasMaxLength(50);
                entity.Property(e => e.StaffNo).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
                entity.Property(e => e.EmailAddress).HasMaxLength(50);
                entity.Property(e => e.Rank).HasMaxLength(50);
                entity.Property(e => e.Gender).HasMaxLength(50);
               

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });
            

            
            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.ToTable("Faculty");
                entity.Property(e => e.FacultyName).HasMaxLength(50);                

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Exit>(entity =>
            {
                entity.ToTable("Exit");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
             
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.Destination).HasMaxLength(50);
                entity.Property(e => e.DepartureDate).HasMaxLength(50);
                entity.Property(e => e.SessionofAdmission).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.ToTable("Entry");
                entity.Property(e => e.MatricNo).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.Registry).HasMaxLength(50);
                entity.Property(e => e.Bursary).HasMaxLength(50);
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.SessionofAdmission).HasMaxLength(50);
                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");
                entity.Property(e => e.RoomNo).HasMaxLength(50);
               
                entity.Property(e => e.TotalBedspace).HasMaxLength(50);
               

                entity.Property(e => e.Created).HasColumnType("datetime");
                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.MatricNumber).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.Faculty).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.Course).HasMaxLength(50);
                entity.Property(e => e.StudentLevel).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
                entity.Property(e => e.EmailAddress).HasMaxLength(50);
                entity.Property(e => e.SessionofAdmission).HasMaxLength(50);
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
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.OtherName).HasMaxLength(50);
                entity.Property(e => e.PhoneNo).HasMaxLength(50);
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
