﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using emojikeyboard.Models;

namespace emojikeyboard.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220902183645_emoji")]
    partial class emoji
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("emojikeyboard.Models.Emoji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("emoji_kod")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("emojis");
                });
#pragma warning restore 612, 618
        }
    }
}
