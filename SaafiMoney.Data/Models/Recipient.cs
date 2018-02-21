namespace SaafiMoney.Data.Models
{
    public class Recipient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }


        public virtual Sender Sender { get; set; }
    }
}
