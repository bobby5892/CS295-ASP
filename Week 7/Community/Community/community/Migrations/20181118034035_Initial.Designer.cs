﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using community.Repositories;

namespace community.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20181118034035_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("community.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("community.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FromID");

                    b.Property<bool>("IsPriority");

                    b.Property<string>("Msge");

                    b.Property<string>("Subject");

                    b.Property<DateTime>("Timestamp");

                    b.Property<int?>("ToID");

                    b.HasKey("ID");

                    b.HasIndex("FromID");

                    b.HasIndex("ToID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("community.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("community.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("community.Models.Message", b =>
                {
                    b.HasOne("community.Models.User", "From")
                        .WithMany()
                        .HasForeignKey("FromID");

                    b.HasOne("community.Models.User", "To")
                        .WithMany()
                        .HasForeignKey("ToID");
                });
#pragma warning restore 612, 618
        }
    }
}
