using MessengerApp_SSC.Models;
using Microsoft.EntityFrameworkCore;

namespace SSC_App.Models
{
    public class MessengerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public MessengerContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=messengerapp;User Id=postgres;Password=cezar1234;");
        }

    }
}
