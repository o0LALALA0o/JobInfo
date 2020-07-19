using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobApi.Models
{
    public partial class JobDBContext : DbContext
    {
        public JobDBContext()
        {
        }

        public JobDBContext(DbContextOptions<JobDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JobImg> JobImg { get; set; }
        public virtual DbSet<JobInfo> JobInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobDB;Integrated Security=True");
                //Data Source=121.40.161.144;Initial Catalog=JobDB;User ID=sa;Password=sa123456.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<JobImg>(entity =>
            {
                entity.HasKey(e => e.ImgId)
                    .HasName("PK__JobImg__352F54F3CD729C84");

                entity.Property(e => e.ImgName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobInfo>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__JobInfo__056690C244B8A966");

                entity.Property(e => e.IsDel).HasColumnName("isDel");

                entity.Property(e => e.JobCo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobContent)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.JobDate).HasColumnType("date");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
