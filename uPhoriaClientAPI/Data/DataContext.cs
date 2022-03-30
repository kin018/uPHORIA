using Microsoft.EntityFrameworkCore;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
