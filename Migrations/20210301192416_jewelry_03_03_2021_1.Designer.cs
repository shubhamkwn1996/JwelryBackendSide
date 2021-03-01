﻿// <auto-generated />
using JwelryBackendSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JwelryBackendSide.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210301192416_jewelry_03_03_2021_1")]
    partial class jewelry_03_03_2021_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JwelryBackendSide.DatabaseLayer.Entity.UserLogin", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Password = "Shubham",
                            UserName = "shubham",
                            UserType = "normal"
                        },
                        new
                        {
                            UserId = 2L,
                            Password = "Sridhar",
                            UserName = "sridhar",
                            UserType = "privileged"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
