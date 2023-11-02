namespace ProjectKaits.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime DateOrder { get; set; }

        public decimal TotalPrice { get; set; }

        public int ClientId { get; set; }

        //Foreigns
        public virtual Client? Client { get; set; }

        public virtual ICollection<OrderDetail>? Details { get; set; }
    }
}
