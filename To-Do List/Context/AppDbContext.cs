using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lista> Lista { get; set; }
        public DbSet<ElementoLista> ElementoLista { get; set; }
    }
}
