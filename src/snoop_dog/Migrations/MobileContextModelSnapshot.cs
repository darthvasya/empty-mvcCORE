using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using snoop_dog.Models;

namespace snoop_dog.Migrations
{
    [DbContext(typeof(MobileContext))]
    partial class MobileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("snoop_dog.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ContactPhone");

                    b.Property<int>("PhoneId");

                    b.Property<string>("User");

                    b.HasKey("OrderId");

                    b.HasIndex("PhoneId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("snoop_dog.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("snoop_dog.Models.Order", b =>
                {
                    b.HasOne("snoop_dog.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
