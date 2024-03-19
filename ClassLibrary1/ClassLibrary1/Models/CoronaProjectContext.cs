using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class CoronaProjectContext : DbContext
{
    public CoronaProjectContext()
    {
    }

    public CoronaProjectContext(DbContextOptions<CoronaProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CoronaInfection> CoronaInfections { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Vaccine> Vaccines { get; set; }

    public virtual DbSet<VaccineType> VaccineTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Corona_Project;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("city");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(15)
                .HasColumnName("city_name");
        });

        modelBuilder.Entity<CoronaInfection>(entity =>
        {
            entity.ToTable("coronaInfection");

            entity.Property(e => e.CoronaInfectionId)
                .HasMaxLength(9)
                .HasColumnName("coronaInfection_id");
            entity.Property(e => e.CoronaInfectionFromDate)
                .HasColumnType("date")
                .HasColumnName("coronaInfection_fromDate");
            entity.Property(e => e.CoronaInfectionToDate)
                .HasColumnType("date")
                .HasColumnName("coronaInfection_toDate");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("member");

            entity.Property(e => e.MemberId)
                .HasMaxLength(9)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberAddress)
                .HasMaxLength(20)
                .HasColumnName("member_address");
            entity.Property(e => e.MemberCityId).HasColumnName("member_city_id");
            entity.Property(e => e.MemberFirstname)
                .HasMaxLength(15)
                .HasColumnName("member_firstname");
            entity.Property(e => e.MemberLastname)
                .HasMaxLength(15)
                .HasColumnName("member_lastname");
            entity.Property(e => e.MemberPhone)
                .HasMaxLength(10)
                .HasColumnName("member_phone");
            entity.Property(e => e.MemberPic)
                .HasMaxLength(30)
                .HasColumnName("member_pic");
            entity.Property(e => e.MemberTelephone)
                .HasMaxLength(9)
                .HasColumnName("member_telephone");

            entity.HasOne(d => d.MemberCity).WithMany(p => p.Members)
                .HasForeignKey(d => d.MemberCityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_city");

            entity.HasOne(d => d.MemberNavigation).WithOne(p => p.Member)
                .HasForeignKey<Member>(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_coronaInfection");
        });

        modelBuilder.Entity<Vaccine>(entity =>
        {
            entity.ToTable("vaccine");

            entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");
            entity.Property(e => e.VaccineDate)
                .HasColumnType("date")
                .HasColumnName("vaccine_date");
            entity.Property(e => e.VaccineMemberId)
                .HasMaxLength(9)
                .HasColumnName("vaccine_member_id");
            entity.Property(e => e.VaccineVaccineTypeId).HasColumnName("vaccine_vaccineType_id");

            entity.HasOne(d => d.VaccineMember).WithMany(p => p.Vaccines)
                .HasForeignKey(d => d.VaccineMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vaccine_member1");

            entity.HasOne(d => d.VaccineVaccineType).WithMany(p => p.Vaccines)
                .HasForeignKey(d => d.VaccineVaccineTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vaccine_vaccineType");
        });

        modelBuilder.Entity<VaccineType>(entity =>
        {
            entity.ToTable("vaccineType");

            entity.Property(e => e.VaccineTypeId).HasColumnName("vaccineType_id");
            entity.Property(e => e.VaccineTypeManufacturer)
                .HasMaxLength(20)
                .HasColumnName("vaccineType_manufacturer");
            entity.Property(e => e.VaccineTypeNumOfVaccinated).HasColumnName("vaccineType_numOfVaccinated");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
