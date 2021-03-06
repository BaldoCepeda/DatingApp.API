using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; } //The name of this property is the name of the table in the DB
        public DbSet<User> Users { get; set;}
        public DbSet<Photo> Photos { get; set; }
    }
}