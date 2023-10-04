using MessengerApp_SSC.Models;
using Microsoft.EntityFrameworkCore;

namespace SSC_App.Models
{
    public class MessengerContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MessengerContext(DbContextOptions options) : base(options)
        {

        }
    }
}
