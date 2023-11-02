namespace ProjectKaits.Dtos
{
    public class SaveOrderDetailDto
    {
        public int OrderDetailId { get; set; }

        public int Quantity { get; set; }

        public string? DetailDescripcion { get; set; }

        public decimal UnitPrice { get; set; }

        public int? ProductId { get; set; }

        public int OrderId { get; set; }
    }
}
