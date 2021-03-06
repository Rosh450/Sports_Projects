// <auto-generated />
using EventsServices.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventsServices.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    [Migration("20220709063739_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EventsServices.Models.Events", b =>
                {
                    b.Property<int>("eventid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("eventid"), 1L, 1);

                    b.Property<string>("eventdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noofslots")
                        .HasColumnType("int");

                    b.Property<string>("sportsname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventid");

                    b.ToTable("events");
                });
#pragma warning restore 612, 618
        }
    }
}
