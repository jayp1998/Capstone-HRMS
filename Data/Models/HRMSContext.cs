using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRMS_Project.Data.Models
{
    public partial class HRMSContext : DbContext
    {
        public HRMSContext()
        {
        }

        public HRMSContext(DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEducationDetail> TblEducationDetails { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEmploymentStatus> TblEmploymentStatuses { get; set; }
        public virtual DbSet<TblGender> TblGenders { get; set; }
        public virtual DbSet<TblJobDetail> TblJobDetails { get; set; }
        public virtual DbSet<TblLeaveApplicationsHistory> TblLeaveApplicationsHistories { get; set; }
        public virtual DbSet<TblLeaveHoursOffered> TblLeaveHoursOffereds { get; set; }
        public virtual DbSet<TblLeaveType> TblLeaveTypes { get; set; }
        public virtual DbSet<TblPosition> TblPositions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-Q2VFICDK;Initial Catalog=HRMS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("TblDepartment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEducationDetail>(entity =>
            {
                entity.HasKey(e => e.EducationDetailsId);

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Gpa)
                    .HasMaxLength(10)
                    .HasColumnName("GPA")
                    .IsFixedLength(true);

                entity.Property(e => e.Specialization)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UniversityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblEducationDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblEducationDetails_TblEmployee");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("TblEmployee");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sin)
                    .HasMaxLength(10)
                    .HasColumnName("SIN")
                    .IsFixedLength(true);

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblEmployee_TblGender");
            });

            modelBuilder.Entity<TblEmploymentStatus>(entity =>
            {
                entity.HasKey(e => e.EmploymentStatusId);

                entity.ToTable("TblEmploymentStatus");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("TblGender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblJobDetail>(entity =>
            {
                entity.HasKey(e => e.JobDetailsId);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.ProbationaryPeriodEndDate).HasColumnType("date");

                entity.Property(e => e.ProbationaryPeriodStartDate).HasColumnType("date");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblJobDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblJobDetails_TblDepartment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblJobDetailEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblJobDetails_TblEmployee");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.TblJobDetails)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblJobDetails_TblEmploymentStatus");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TblJobDetails)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblJobDetails_TblPositions");

                entity.HasOne(d => d.ReportsToNavigation)
                    .WithMany(p => p.TblJobDetailReportsToNavigations)
                    .HasForeignKey(d => d.ReportsTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblJobDetails_TblEmployee1");
            });

            modelBuilder.Entity<TblLeaveApplicationsHistory>(entity =>
            {
                entity.HasKey(e => e.LeaveApplicationId);

                entity.ToTable("TblLeaveApplicationsHistory");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.LeaveAppliedOn).HasColumnType("date");

                entity.Property(e => e.LeaveFrom).HasColumnType("date");

                entity.Property(e => e.LeaveStatusUpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.LeaveTo).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.HasOne(d => d.LeaveAppliedByNavigation)
                    .WithMany(p => p.TblLeaveApplicationsHistoryLeaveAppliedByNavigations)
                    .HasForeignKey(d => d.LeaveAppliedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveApplicationsHistory_TblEmployee");

                entity.HasOne(d => d.LeaveAppliedToNavigation)
                    .WithMany(p => p.TblLeaveApplicationsHistoryLeaveAppliedToNavigations)
                    .HasForeignKey(d => d.LeaveAppliedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveApplicationsHistory_TblEmployee1");

                entity.HasOne(d => d.LeaveStatusUpdatedByNavigation)
                    .WithMany(p => p.TblLeaveApplicationsHistoryLeaveStatusUpdatedByNavigations)
                    .HasForeignKey(d => d.LeaveStatusUpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveApplicationsHistory_TblEmployee2");

                entity.HasOne(d => d.LeaveTypeNavigation)
                    .WithMany(p => p.TblLeaveApplicationsHistories)
                    .HasForeignKey(d => d.LeaveType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveApplicationsHistory_TblLeaveType");
            });

            modelBuilder.Entity<TblLeaveHoursOffered>(entity =>
            {
                entity.HasKey(e => e.LeaveHoursOfferedId);

                entity.ToTable("TblLeaveHoursOffered");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblLeaveHoursOfferedEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveHoursOffered_TblEmployee");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.TblLeaveHoursOffereds)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblLeaveHoursOffered_TblLeaveType");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TblLeaveHoursOfferedUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_TblLeaveHoursOffered_TblEmployee1");
            });

            modelBuilder.Entity<TblLeaveType>(entity =>
            {
                entity.HasKey(e => e.LeaveTypeId);

                entity.ToTable("TblLeaveType");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.Property(e => e.PositionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Position)
                    .WithOne(p => p.TblPosition)
                    .HasForeignKey<TblPosition>(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblPositions_TblDepartment");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblUsers_TblEmployee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
