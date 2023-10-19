
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDo_List.Models;

namespace ToDo_List.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
