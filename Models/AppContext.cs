using Microsoft.EntityFrameworkCore;

namespace Day4_Task1.Models
{
    internal class AppContext:DbContext
    {
        private readonly string _connectionString = @"Data Source=.;Initial Catalog=MYDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
