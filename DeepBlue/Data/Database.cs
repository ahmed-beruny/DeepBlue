using DeepBlue.Models;
using Microsoft.EntityFrameworkCore;

namespace DeepBlue.Data
{
    public class Database:DbContext
    {

        public Database(DbContextOptions<Database> options): base(options)
        {

        }

        public DbSet<Members> Members { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}
