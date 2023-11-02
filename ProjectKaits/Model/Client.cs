namespace ProjectKaits.Model
{
    public class Client
    {
        public int ClientId { get; set; }

        public string? ClientName { get; set; }

        public string? DNI { get; set; }

        //Foreigns
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
