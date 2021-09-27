﻿// <auto-generated />
using System;
using LogApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogApi.Migrations
{
    [DbContext(typeof(LoggingContext))]
    [Migration("20210927104138_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("LogApi.Log", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Level")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LogId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("Renderedmessage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("LogId");

                    b.HasIndex("LogId1");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("LogApi.Log", b =>
                {
                    b.HasOne("LogApi.Log", null)
                        .WithMany("Posts")
                        .HasForeignKey("LogId1");
                });

            modelBuilder.Entity("LogApi.Log", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
