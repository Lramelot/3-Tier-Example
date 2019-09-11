﻿// <auto-generated />
using System;
using Jawad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jawad.Data.Migrations
{
    [DbContext(typeof(BeersContext))]
    partial class BeersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jawad.Data.Entities.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AlcoolPercentage");

                    b.Property<int?>("BrewerId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrewerId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("Jawad.Data.Entities.Brewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brewers");
                });

            modelBuilder.Entity("Jawad.Data.Entities.Beer", b =>
                {
                    b.HasOne("Jawad.Data.Entities.Brewer", "Brewer")
                        .WithMany("Beers")
                        .HasForeignKey("BrewerId");
                });
#pragma warning restore 612, 618
        }
    }
}