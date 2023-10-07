using Hanover.Models;
using Microsoft.EntityFrameworkCore;

namespace Hanover.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        
        public DbSet<ContactModel> ContactModel { get; set; }
    }
}
