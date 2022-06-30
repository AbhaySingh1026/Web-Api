using CONNECT_API_TO_DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace CONNECT_API_TO_DB
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public ApiDbContext()
        {

        }
        public ApiDbContext(DbContextOptions options)
        : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I3CUF5I;Initial Catalog=ApiDb;Integrated Security=True");
        }
    }
}
