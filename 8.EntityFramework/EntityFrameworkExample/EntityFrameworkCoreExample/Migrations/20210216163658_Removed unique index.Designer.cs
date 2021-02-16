﻿// <auto-generated />
using EntityFrameworkCoreExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCoreExample.Migrations
{
    [DbContext(typeof(CharactersDbContext))]
    [Migration("20210216163658_Removed unique index")]
    partial class Removeduniqueindex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Author", b =>
                {
                    b.Property<int>("AuthorIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CreatorId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorIdentifier");

                    b.ToTable("Creators");
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            FirstName = "Harry",
                            Gender = true,
                            LastName = "Seldon",
                            StoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 2700,
                            FirstName = "Arven",
                            Gender = false,
                            LastName = "Undomiel",
                            StoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 14,
                            FirstName = "Finn",
                            Gender = true,
                            LastName = "Mertens",
                            StoryId = 3
                        });
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Foundation"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "LOTR"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Hyperion"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Character", b =>
                {
                    b.HasOne("EntityFrameworkCoreExample.Models.Story", "Story")
                        .WithMany("Characters")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Story", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
