using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AppToDo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppToDo.Repository.DBContext
{
    public class AppToDoDbContext:DbContext
    {
        public AppToDoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDoAction> ToDoAction { get; set; }
        public DbSet<ToDoList> ToDoList { get; set; }
        public DbSet<ToDoItem> ToDoItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
