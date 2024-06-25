using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AttendMgmtSystm.Models
{
    public partial class AttenMgmtSystmContext : DbContext
    {
        public AttenMgmtSystmContext()
        {
        }

        public AttenMgmtSystmContext(DbContextOptions<AttenMgmtSystmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttMst> AttMsts { get; set; }
        public virtual DbSet<EmpMst> EmpMsts { get; set; }
        public virtual DbSet<ShiftMst> ShiftMsts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ANS\\SQLEXPRESS;Database=AttenMgmtSystm;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AttMst>(entity =>
            {
                entity.ToTable("att_mst");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckInDate).HasColumnType("date");

                entity.Property(e => e.CheckInDateTime).HasColumnType("datetime");

                entity.Property(e => e.CheckOutDate).HasColumnType("date");

                entity.Property(e => e.CheckOutdateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ShiftId).HasColumnName("shift_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_on");
            });

            modelBuilder.Entity<EmpMst>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__emp_mst__1299A86155C8CFEE");

                entity.ToTable("emp_mst");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.Passw)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passw");

                entity.Property(e => e.PhNo).HasColumnName("ph_no");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_on");
            });

            modelBuilder.Entity<ShiftMst>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK__shift_ms__7B2672204EC63A1D");

                entity.ToTable("shift_mst");

                entity.Property(e => e.ShiftId).HasColumnName("shift_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("shift_name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_on");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
