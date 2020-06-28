using Microsoft.EntityFrameworkCore; 
using DatingApp.API.Models; 

namespace DatingApp.API.Data
{
    public class DataContext : DbContext // deriving from an entity framework
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; } // Values is table name that gets created
        // DbContext represents Entity db context, which handles fetching, storing, and updating a Value instance in the database
    }
}