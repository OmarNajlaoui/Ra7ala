// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ra7ala.data;

#nullable disable

namespace Ra7ala.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220518063211_createDb")]
    partial class createDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ErrahalaPC.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Kharja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KharjaCategorie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisateurId")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("OrganisateurId");

                    b.ToTable("Kharjet");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Kharja_sites", b =>
                {
                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.Property<int>("KharjaId")
                        .HasColumnType("int");

                    b.HasKey("SiteId", "KharjaId");

                    b.HasIndex("KharjaId");

                    b.ToTable("Kharja_Sites");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Organisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisateurs");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Kharja", b =>
                {
                    b.HasOne("ErrahalaPC.Models.Hotel", "Hotel")
                        .WithMany("Kharjas")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ErrahalaPC.Models.Organisateur", "Organisateur")
                        .WithMany("Kharjas")
                        .HasForeignKey("OrganisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Organisateur");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Kharja_sites", b =>
                {
                    b.HasOne("ErrahalaPC.Models.Kharja", "kharja")
                        .WithMany("kharja_Sites")
                        .HasForeignKey("KharjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ErrahalaPC.Models.Site", "site")
                        .WithMany("kharja_Sites")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kharja");

                    b.Navigation("site");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Hotel", b =>
                {
                    b.Navigation("Kharjas");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Kharja", b =>
                {
                    b.Navigation("kharja_Sites");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Organisateur", b =>
                {
                    b.Navigation("Kharjas");
                });

            modelBuilder.Entity("ErrahalaPC.Models.Site", b =>
                {
                    b.Navigation("kharja_Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
