﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Report.API.Data;

namespace Report.API.Data.Migrations
{
    [DbContext(typeof(PostgreSqlReportDbContext))]
    partial class PostgreSqlReportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Report.API.Domain.Entities.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Candidate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3190d79f-b975-4f60-9f30-0b7e2c3a1eb6"),
                            CreatedDate = new DateTime(2023, 1, 8, 16, 39, 0, 510, DateTimeKind.Local).AddTicks(2933),
                            IsActive = true,
                            Name = "Candidate 1"
                        },
                        new
                        {
                            Id = new Guid("d733adcf-45ad-4029-98b1-a4d269f39872"),
                            CreatedDate = new DateTime(2023, 1, 8, 16, 39, 0, 511, DateTimeKind.Local).AddTicks(904),
                            IsActive = true,
                            Name = "Candidate 2"
                        },
                        new
                        {
                            Id = new Guid("5af7c85e-f941-4080-afc4-185852172d1b"),
                            CreatedDate = new DateTime(2023, 1, 8, 16, 39, 0, 511, DateTimeKind.Local).AddTicks(932),
                            IsActive = true,
                            Name = "Candidate 3"
                        },
                        new
                        {
                            Id = new Guid("a31a3514-9414-49be-b361-47be256e831e"),
                            CreatedDate = new DateTime(2023, 1, 8, 16, 39, 0, 511, DateTimeKind.Local).AddTicks(934),
                            IsActive = true,
                            Name = "Candidate 4"
                        });
                });

            modelBuilder.Entity("Report.API.Domain.Entities.ContactDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContactRef")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("DetailRef")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("ContactDetail");
                });

            modelBuilder.Entity("Report.API.Domain.Entities.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ContactCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("PhoneCount")
                        .HasColumnType("integer");

                    b.Property<byte>("ReportStatus")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("Report.API.Domain.Entities.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CandidateRef")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("VoteCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Vote");
                });
#pragma warning restore 612, 618
        }
    }
}
