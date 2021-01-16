﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterClone.Models;

namespace TwitterClone.Migrations
{
    [DbContext(typeof(TwitterContext))]
    [Migration("20210116061324_v1.1.6")]
    partial class v116
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.Property<long>("TweetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationMonth")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerMail")
                        .HasColumnType("TEXT");

                    b.Property<long?>("TweetID1")
                        .HasColumnType("INTEGER");

                    b.HasKey("TweetID");

                    b.HasIndex("OwnerMail");

                    b.HasIndex("TweetID1");

                    b.ToTable("Tweets");
                });

            modelBuilder.Entity("TwitterClone.Models.User", b =>
                {
                    b.Property<string>("Mail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Biography")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverPicture")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationMonth")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreationYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Month")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Mail");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<string>("FollowersMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("FollowingMail")
                        .HasColumnType("TEXT");

                    b.HasKey("FollowersMail", "FollowingMail");

                    b.HasIndex("FollowingMail");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.HasOne("TwitterClone.Models.User", "Owner")
                        .WithMany("Tweets")
                        .HasForeignKey("OwnerMail");

                    b.HasOne("TwitterClone.Models.Tweet", null)
                        .WithMany("Comments")
                        .HasForeignKey("TweetID1");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("TwitterClone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersMail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwitterClone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("FollowingMail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TwitterClone.Models.User", b =>
                {
                    b.Navigation("Tweets");
                });
#pragma warning restore 612, 618
        }
    }
}