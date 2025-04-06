using Microsoft.EntityFrameworkCore;
using Model;
namespace Storage
{
    public class TestTaskContext : DbContext
    {
        public TestTaskContext (DbContextOptions<TestTaskContext> options)
            : base(options)
        {

            
           
        }

        public DbSet<Model.User> Users { get; set; } 
        public DbSet<Model.Subdivision> Subdivisions { get; set; } 
    }
}
