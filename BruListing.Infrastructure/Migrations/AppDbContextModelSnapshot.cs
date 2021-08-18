﻿// <auto-generated />
using System;
using BruListing.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BruListing.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("BruListing.Core.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BruListing.Core.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<decimal>("MaximumCompensation")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("MinimumCompensation")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("PrimaryTagId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PrimaryTagId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("BruListing.Core.PrimaryTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PrimaryTags");
                });

            modelBuilder.Entity("BruListing.Core.Job", b =>
                {
                    b.HasOne("BruListing.Core.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId");

                    b.HasOne("BruListing.Core.PrimaryTag", "PrimaryTag")
                        .WithMany("Jobs")
                        .HasForeignKey("PrimaryTagId");

                    b.Navigation("Company");

                    b.Navigation("PrimaryTag");
                });

            modelBuilder.Entity("BruListing.Core.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("BruListing.Core.PrimaryTag", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
