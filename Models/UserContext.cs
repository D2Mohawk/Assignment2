using Microsoft.EntityFrameworkCore;

namespace Assignment2_1.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
            {

            }
            public DbSet<User> Users  {get; set;}
    }
}