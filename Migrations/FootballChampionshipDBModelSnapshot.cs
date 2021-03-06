﻿// <auto-generated />
using FootballChempionship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballChempionship.Migrations
{
    [DbContext(typeof(FootballChampionshipDB))]
    partial class FootballChampionshipDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballChempionship.Championship", b =>
                {
                    b.Property<int>("ChampionshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("scoreA")
                        .HasColumnType("int");

                    b.Property<int>("scoreB")
                        .HasColumnType("int");

                    b.Property<int>("teamAId")
                        .HasColumnType("int");

                    b.Property<int>("teamBId")
                        .HasColumnType("int");

                    b.HasKey("ChampionshipId");

                    b.ToTable("championships");
                });

            modelBuilder.Entity("FootballChempionship.FootballTeam", b =>
                {
                    b.Property<int>("FootballTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.Property<string>("teamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FootballTeamId");

                    b.ToTable("footballTeams");
                });
#pragma warning restore 612, 618
        }
    }
}
