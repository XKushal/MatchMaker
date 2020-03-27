using Microsoft.EntityFrameworkCore;
using DatingApp.API.Model;
namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        //Deriving from this
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values{get; set;}
    }
}