﻿// <auto-generated />
using InfoSystem.Infrastructure.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InfoSystem.Infrastructure.Migrations
{
    [DbContext(typeof(InfoSystemDbContext))]
    [Migration("20190304191638_EAV-Simple")]
    partial class EAVSimple
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("InfoSystem.Core.Entities.Basic.Atttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TypeId");

                    b.Property<string>("ValueType");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("InfoSystem.Core.Entities.Basic.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("InfoSystem.Core.Entities.Basic.EntityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("InfoSystem.Core.Entities.Basic.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeId");

                    b.Property<string>("Content");

                    b.Property<int>("EntityId");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
