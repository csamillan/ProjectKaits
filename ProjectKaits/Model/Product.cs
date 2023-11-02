namespace ProjectKaits.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? ProductDescripcion { get; set; }

        //Foreigns
        public virtual OrderDetail? Detail { get; set; }
    }
}
