﻿// <auto-generated />
using System;
using CarStore.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDescriptionEntityCarFeaturesEntity", b =>
                {
                    b.Property<int>("CarDescriptionsId")
                        .HasColumnType("int");

                    b.Property<int>("CarFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("CarDescriptionsId", "CarFeaturesId");

                    b.HasIndex("CarFeaturesId");

                    b.ToTable("CarDescriptionEntityCarFeaturesEntity");
                });

            modelBuilder.Entity("CarStore.Models.Entity.CarDescriptionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CarDescriptions");
                });

            modelBuilder.Entity("CarStore.Models.Entity.CarFeaturesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarFeatures");
                });

            modelBuilder.Entity("CarStore.Models.Entity.DescriptionFeaturesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarDescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("CarFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarDescriptionId");

                    b.HasIndex("CarFeaturesId");

                    b.ToTable("DescriptionFeatures");
                });

            modelBuilder.Entity("CarDescriptionEntityCarFeaturesEntity", b =>
                {
                    b.HasOne("CarStore.Models.Entity.CarDescriptionEntity", null)
                        .WithMany()
                        .HasForeignKey("CarDescriptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarStore.Models.Entity.CarFeaturesEntity", null)
                        .WithMany()
                        .HasForeignKey("CarFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarStore.Models.Entity.DescriptionFeaturesEntity", b =>
                {
                    b.HasOne("CarStore.Models.Entity.CarDescriptionEntity", "CarDescription")
                        .WithMany()
                        .HasForeignKey("CarDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarStore.Models.Entity.CarFeaturesEntity", "CarFeatures")
                        .WithMany()
                        .HasForeignKey("CarFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarDescription");

                    b.Navigation("CarFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}