﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task_2._1._1.DAL;

namespace Task_2._1._1.Migrations
{
    [DbContext(typeof(CustomersCardsContext))]
    partial class CustomersCardsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task_2._1._1.DAL.Model.PersonalCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Discount")
                        .HasColumnType("real")
                        .HasColumnName("discount");

                    b.HasKey("Id");

                    b.ToTable("personal_card");
                });

            modelBuilder.Entity("Task_2._1._1.DAL.Model.Purchase", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CardId")
                        .HasColumnType("bigint")
                        .HasColumnName("card_id");

                    b.Property<decimal?>("PurchaseSum")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("purchase_sum");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("purchase");
                });

            modelBuilder.Entity("Task_2._1._1.DAL.Model.UserProfile", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.HasKey("UserId");

                    b.ToTable("user_profile");
                });

            modelBuilder.Entity("Task_2._1._1.DAL.Model.Purchase", b =>
                {
                    b.HasOne("Task_2._1._1.DAL.Model.PersonalCard", "PersonalCard")
                        .WithMany("Purchases")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("PersonalCard");
                });

            modelBuilder.Entity("Task_2._1._1.DAL.Model.UserProfile", b =>
                {
                    b.HasOne("Task_2._1._1.DAL.Model.PersonalCard", "PersonalCard")
                        .WithOne("UserProfile")
                        .HasForeignKey("Task_2._1._1.DAL.Model.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalCard");
                });

            modelBuilder.Entity("Task_2._1._1.DAL.Model.PersonalCard", b =>
                {
                    b.Navigation("Purchases");

                    b.Navigation("UserProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
