namespace ProjectKaits.Dtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public DateTime DateOrder { get; set; }

        public decimal TotalPrice { get; set; }

        public int ClientId { get; set; }

        public virtual ClientDto? Client { get; set; }

        public virtual ICollection<OrderDetailDto>? Details { get; set; }
    }
}
