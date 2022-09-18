using Microsoft.EntityFrameworkCore;

namespace Assignment2_1.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext (DbContextOptions<UserDbContext> options)
            : base(options)
            {

            }
            public DbSet<User> Users  {get; set;}
    }
}