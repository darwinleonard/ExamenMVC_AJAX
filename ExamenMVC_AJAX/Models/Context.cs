using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamenMVC_AJAX.Models
{
    public class Context : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
    
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    }
}
