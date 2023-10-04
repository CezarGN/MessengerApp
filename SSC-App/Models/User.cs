using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessengerApp_SSC.Models
{
    public class User : ModelBuilder
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }

        public User()
        {

        }

        public User(int id, string username)
        {
            this.username = username;
        }
    }
}
