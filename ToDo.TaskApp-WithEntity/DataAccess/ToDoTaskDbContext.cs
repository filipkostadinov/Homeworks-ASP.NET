using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.Domain;

namespace DataAccess
{
    public class ToDoTaskDbContext : DbContext
    {
        public ToDoTaskDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTask>().HasMany(x => x.SubTask).WithOne(x => x.ToDoTask);
            modelBuilder.Entity<User>().HasMany(x => x.Tasks).WithOne(x => x.User);

            modelBuilder.Entity<User>()
                .HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Age = 20,
                    AverageFreeTime = 30,
                }
                );
        }
    }
}
