using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessengerApp_SSC.Models
{
    public class Message : ModelBuilder
    {
        [Key]
        public int id { get; set; }

        public string content { get; set; }
        
        public string sender { get; set; }
        
        public string receiver { get; set; }
        
        public DateTime timeStamp { get; set; }
        public Message() {
        }

        public Message(string content, string sender, string receiver, DateTime timeStamp)
        {
            this.content = content;
            this.sender = sender;
            this.receiver = receiver;
            this.timeStamp = timeStamp;
        }

    }
}
