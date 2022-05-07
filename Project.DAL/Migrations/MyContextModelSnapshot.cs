﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DAL.Concrete.EntityFramework.Context;

namespace Project.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ActivationCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("ID");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID")
                        .IsUnique()
                        .HasFilter("[AppUserID] IS NOT NULL");

                    b.ToTable("AppUserProfiles");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("CommentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<decimal>("PriceOffer")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<string>("EventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.EventComment", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<int>("CommentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Deleted Date");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("EventID", "CommentID");

                    b.HasIndex("CommentID");

                    b.ToTable("EventComments");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithOne("Profile")
                        .HasForeignKey("Project.ENTITIES.Models.AppUserProfile", "AppUserID");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Comment", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Event", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Events")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.EventComment", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.Comment", "Comment")
                        .WithMany("EventComments")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.Event", "Event")
                        .WithMany("EventComments")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Events");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Comment", b =>
                {
                    b.Navigation("EventComments");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Event", b =>
                {
                    b.Navigation("EventComments");
                });
#pragma warning restore 612, 618
        }
    }
}
