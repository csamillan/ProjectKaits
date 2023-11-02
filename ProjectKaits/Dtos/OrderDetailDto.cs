namespace ProjectKaits.Dtos
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }

        public int Quantity { get; set; }

        public string? DetailDescripcion { get; set; }

        public decimal UnitPrice { get; set; }

        public int? ProductId { get; set; }

        public int OrderId { get; set; }

        public virtual OrderDto? Order { get; set; }

        public virtual ICollection<ProductDto>? Products { get; set; }
    }
}
