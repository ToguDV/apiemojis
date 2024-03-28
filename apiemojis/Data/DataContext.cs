using apiemojis.Models;
using Microsoft.EntityFrameworkCore;

namespace apiemojis.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public virtual DbSet<Trivia> Trivias { get; set; }
      


    }
}
