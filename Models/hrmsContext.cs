using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class hrmsContext : DbContext
    {
        public hrmsContext()
        {
        }

        public hrmsContext(DbContextOptions<hrmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cv> Cvs { get; set; }
        public virtual DbSet<Employeer> Employeers { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<JobAdvertisement> JobAdvertisements { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=hrms;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Cv>(entity =>
            {
                entity.ToTable("cv");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CoverLetter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coverLetter");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.Github)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("github");

                entity.Property(e => e.Images)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("images");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.School)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("school");

                entity.Property(e => e.WorkExperience)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("workExperience");
            });

            modelBuilder.Entity<Employeer>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.PositionId).HasColumnName("position_id");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.ToTable("Employer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CompanyAdress)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("company_adress");

                entity.Property(e => e.CompanyEmail)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("company_email");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company_number");

                entity.Property(e => e.CompanyWebAdress)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("company_web_adress");
            });

            modelBuilder.Entity<JobAdvertisement>(entity =>
            {
                entity.ToTable("job_advertisement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Employer)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("employer");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(110)
                    .IsUnicode(false)
                    .HasColumnName("job_description");

                entity.Property(e => e.JobPosition)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("job_position");

                entity.Property(e => e.MaxSalary).HasColumnName("max_salary");

                entity.Property(e => e.MinSalary).HasColumnName("min_salary");

                entity.Property(e => e.Phone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.WorkType)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Work_type");
            });

            modelBuilder.Entity<JobSeeker>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Companybs)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("companybs");

                entity.Property(e => e.CompanycatchPhrase)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("companycatchPhrase");

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("companyname");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("website");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
