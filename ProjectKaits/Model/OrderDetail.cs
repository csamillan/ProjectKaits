namespace ProjectKaits.Model
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int Quantity { get; set; }

        public string? DetailDescripcion { get; set; }

        public decimal UnitPrice { get; set; }

        public int? ProductId { get; set; }

        public int OrderId { get; set; }

        //Foreigns
        public virtual Order? Order { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
