﻿// <auto-generated />
using System;
using HabitTracker.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HabitTracker.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240324175011_DeleteLevelTable")]
    partial class DeleteLevelTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HabitTracker.Models.Habit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("QuantityPerWeek")
                        .HasColumnType("int");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("HabitTracker.Models.HabitRealization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("HabitId")
                        .HasColumnType("int");

                    b.Property<int>("IfExecuted")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("HabitRealizations");
                });

            modelBuilder.Entity("HabitTracker.Models.ScoringModels.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ScoreValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ScoreValue = 0
                        });
                });

            modelBuilder.Entity("HabitTracker.Models.ViewSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconDone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPartiallyDone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ViewSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "00CED1",
                            IconDone = "bi bi-check-square-fill",
                            IconPartiallyDone = "bi bi-check-square"
                        });
                });

            modelBuilder.Entity("HabitTracker.Models.HabitRealization", b =>
                {
                    b.HasOne("HabitTracker.Models.Habit", "habit")
                        .WithMany("habitRealizations")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("habit");
                });

            modelBuilder.Entity("HabitTracker.Models.Habit", b =>
                {
                    b.Navigation("habitRealizations");
                });
#pragma warning restore 612, 618
        }
    }
}
