using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Todo
{
    // TodoContext.cs
    using Microsoft.EntityFrameworkCore;

    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }

}
