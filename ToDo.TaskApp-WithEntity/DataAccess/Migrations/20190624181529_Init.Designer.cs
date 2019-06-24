﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ToDoTaskDbContext))]
    [Migration("20190624181529_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDo.TaskApp.Domain.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("ToDoTaskId");

                    b.HasKey("Id");

                    b.HasIndex("ToDoTaskId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("ToDo.TaskApp.Domain.ToDoTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Priority");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("TypeOfTask");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ToDoTasks");
                });

            modelBuilder.Entity("ToDo.TaskApp.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<double>("AverageFreeTime");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToDo.TaskApp.Domain.SubTask", b =>
                {
                    b.HasOne("ToDo.TaskApp.Domain.ToDoTask", "ToDoTask")
                        .WithMany("SubTask")
                        .HasForeignKey("ToDoTaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDo.TaskApp.Domain.ToDoTask", b =>
                {
                    b.HasOne("ToDo.TaskApp.Domain.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
