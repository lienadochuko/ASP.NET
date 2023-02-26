using Microsoft.EntityFrameworkCore;
using study.Models;

namespace study.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Tabledata> Tabledatas { get; set; }
    }
}
