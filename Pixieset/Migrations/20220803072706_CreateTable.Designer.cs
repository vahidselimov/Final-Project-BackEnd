﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pixieset.DAL;

namespace Pixieset.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220803072706_CreateTable")]
    partial class CreateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pixieset.Models.SocialIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SocialmediasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialmediasId");

                    b.ToTable("socialicons");
                });

            modelBuilder.Entity("Pixieset.Models.Socialmedias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Right")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Span1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Span2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Span3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("socialmedias");
                });

            modelBuilder.Entity("Pixieset.Models.SocialIcons", b =>
                {
                    b.HasOne("Pixieset.Models.Socialmedias", "Socialmedias")
                        .WithMany("SocialIcons")
                        .HasForeignKey("SocialmediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
