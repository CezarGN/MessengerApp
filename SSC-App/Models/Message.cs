namespace MessengerApp_SSC.Models
{
    public class Message
    {
        private int id { get; set; }
        private String content { get; set; }
        private String sender { get; set; }
        private String receiver { get; set; }
        private DateTime timeStamp { get; set; }
        public Message() {
        }

    }
}
