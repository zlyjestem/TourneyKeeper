﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TK.Tournaments.WebAPI.Entities;

namespace TK.Tournaments.WebAPI.Migrations
{
    [DbContext(typeof(TourneyKeeperContext))]
    [Migration("20181116134700_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TourneyKeeper.Entities.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Currency");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<bool>("IfProgressiveCut");

                    b.Property<bool>("IfTopCut");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<float>("Price");

                    b.Property<int>("SizeOfTopCut");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<string>("StreamLink");

                    b.Property<int>("SwissRounds");

                    b.Property<string>("Venue");

                    b.Property<int>("WinsNeededForProgressiveCut");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });
#pragma warning restore 612, 618
        }
    }
}
