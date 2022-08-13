﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pixieset.DAL;

namespace Pixieset.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220809152846_CreateWebsitedom")]
    partial class CreateWebsitedom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pixieset.Models.Act", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Acts");
                });

            modelBuilder.Entity("Pixieset.Models.ActionsIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExampleActionsId")
                        .HasColumnType("int");

                    b.Property<int?>("ExapleActionsId")
                        .HasColumnType("int");

                    b.Property<string>("Icon1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Span")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleActionsId");

                    b.ToTable("ActionsIcons");
                });

            modelBuilder.Entity("Pixieset.Models.CDR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CDRs");
                });

            modelBuilder.Entity("Pixieset.Models.CIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CIcons");
                });

            modelBuilder.Entity("Pixieset.Models.Cards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Span")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Pixieset.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Pixieset.Models.ClientTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientTrs");
                });

            modelBuilder.Entity("Pixieset.Models.Cols", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cols");
                });

            modelBuilder.Entity("Pixieset.Models.Commission_feeTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommissionFeeTrs");
                });

            modelBuilder.Entity("Pixieset.Models.Digital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftSpan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftText3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leftli1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leftli2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leftli3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leftli4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightSpan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightText3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rightli1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rightli2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rightli3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rightli4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Digital");
                });

            modelBuilder.Entity("Pixieset.Models.ExampleActions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImagename1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImagename2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImagename3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeImagename4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleActions");
                });

            modelBuilder.Entity("Pixieset.Models.ExampleFirst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleFirsts");
                });

            modelBuilder.Entity("Pixieset.Models.ExampleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DataId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleMenus");
                });

            modelBuilder.Entity("Pixieset.Models.ExamplesRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExamplesRows");
                });

            modelBuilder.Entity("Pixieset.Models.ExpTitles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExpTitles");
                });

            modelBuilder.Entity("Pixieset.Models.Flow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlowImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowRight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flows");
                });

            modelBuilder.Entity("Pixieset.Models.Get", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gets");
                });

            modelBuilder.Entity("Pixieset.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExpTitlesId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpTitlesId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Pixieset.Models.Mobileapp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mobileapp");
                });

            modelBuilder.Entity("Pixieset.Models.Pages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Pixieset.Models.PricingFirst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PricingFirst");
                });

            modelBuilder.Entity("Pixieset.Models.PricingMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DataId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PricingMenus");
                });

            modelBuilder.Entity("Pixieset.Models.ProductFirst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductFirst");
                });

            modelBuilder.Entity("Pixieset.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("Pixieset.Models.SocialIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialmediasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialmediasId");

                    b.ToTable("Socialicons");
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

                    b.ToTable("Socialmedias");
                });

            modelBuilder.Entity("Pixieset.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Pixieset.Models.StorgeTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StorgeTrs");
                });

            modelBuilder.Entity("Pixieset.Models.TabHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TabHeader");
                });

            modelBuilder.Entity("Pixieset.Models.ThBtn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThBtn");
                });

            modelBuilder.Entity("Pixieset.Models.TrIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CDRId")
                        .HasColumnType("int");

                    b.Property<int?>("CIconsId")
                        .HasColumnType("int");

                    b.Property<string>("IconsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrId")
                        .HasColumnType("int");

                    b.Property<int?>("TrNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CDRId");

                    b.HasIndex("CIconsId");

                    b.HasIndex("TrNameId");

                    b.ToTable("TrIcons");
                });

            modelBuilder.Entity("Pixieset.Models.TrName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrNames");
                });

            modelBuilder.Entity("Pixieset.Models.VUploadTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VUploadTrs");
                });

            modelBuilder.Entity("Pixieset.Models.WebsiteDomTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebsiteDomTr");
                });

            modelBuilder.Entity("Pixieset.Models.WebsiteIconsTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WebsiteDomId")
                        .HasColumnType("int");

                    b.Property<int?>("WebsiteDomTrId")
                        .HasColumnType("int");

                    b.Property<int>("WebsiteNameId")
                        .HasColumnType("int");

                    b.Property<int?>("WebsiteNameTrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebsiteDomTrId");

                    b.HasIndex("WebsiteNameTrId");

                    b.ToTable("WebsitesIcons");
                });

            modelBuilder.Entity("Pixieset.Models.WebsiteNameTr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebsitesNames");
                });

            modelBuilder.Entity("Pixieset.Models.ActionsIcons", b =>
                {
                    b.HasOne("Pixieset.Models.ExampleActions", "ExampleActions")
                        .WithMany("ActionsIcons")
                        .HasForeignKey("ExampleActionsId");
                });

            modelBuilder.Entity("Pixieset.Models.Item", b =>
                {
                    b.HasOne("Pixieset.Models.ExpTitles", "ExpTitles")
                        .WithMany("Items")
                        .HasForeignKey("ExpTitlesId");
                });

            modelBuilder.Entity("Pixieset.Models.SocialIcons", b =>
                {
                    b.HasOne("Pixieset.Models.Socialmedias", "Socialmedias")
                        .WithMany("SocialIcons")
                        .HasForeignKey("SocialmediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pixieset.Models.TrIcons", b =>
                {
                    b.HasOne("Pixieset.Models.CDR", "CDR")
                        .WithMany("TrIcons")
                        .HasForeignKey("CDRId");

                    b.HasOne("Pixieset.Models.CIcons", "CIcons")
                        .WithMany("TrIcons")
                        .HasForeignKey("CIconsId");

                    b.HasOne("Pixieset.Models.TrName", "TrName")
                        .WithMany("TrIcons")
                        .HasForeignKey("TrNameId");
                });

            modelBuilder.Entity("Pixieset.Models.WebsiteIconsTr", b =>
                {
                    b.HasOne("Pixieset.Models.WebsiteDomTr", "WebsiteDomTr")
                        .WithMany("WebsiteIcons")
                        .HasForeignKey("WebsiteDomTrId");

                    b.HasOne("Pixieset.Models.WebsiteNameTr", "WebsiteNameTr")
                        .WithMany("List")
                        .HasForeignKey("WebsiteNameTrId");
                });
#pragma warning restore 612, 618
        }
    }
}
