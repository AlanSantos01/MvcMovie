﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20240223194934_MovieAndStudio")]
    partial class MovieAndStudio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("MvcMovie.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Site")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("MovieId");

                    b.HasIndex("StudioId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MvcMovie.Models.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Site")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("MvcMovie.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MvcMovie.Models.Artist", b =>
                {
                    b.HasOne("MvcMovie.Models.Artist", null)
                        .WithMany("MovieArtists")
                        .HasForeignKey("ArtistId");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.HasOne("MvcMovie.Models.Artist", null)
                        .WithMany("Movie")
                        .HasForeignKey("ArtistId");

                    b.HasOne("MvcMovie.Models.Movie", null)
                        .WithMany("MovieArtists")
                        .HasForeignKey("MovieId");

                    b.HasOne("MvcMovie.Models.Studio", "Studio")
                        .WithMany("Movies")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("MvcMovie.Models.Artist", b =>
                {
                    b.Navigation("Movie");

                    b.Navigation("MovieArtists");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Navigation("MovieArtists");
                });

            modelBuilder.Entity("MvcMovie.Models.Studio", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
