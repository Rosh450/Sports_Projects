﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsService.Models;

#nullable disable

namespace SportsService.Migrations
{
    [DbContext(typeof(SportsDbContext))]
    partial class SportsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportsService.Models.Sports", b =>
                {
                    b.Property<int>("sportsid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sportsid"), 1L, 1);

                    b.Property<int>("noofplayers")
                        .HasColumnType("int");

                    b.Property<string>("sportsname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sportstype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sportsid");

                    b.ToTable("sports");
                });
#pragma warning restore 612, 618
        }
    }
}
