namespace ProjectKaits.Dtos
{
    public class SaveOrderDto
    {
        public DateTime DateOrder { get; set; }

        public decimal TotalPrice { get; set; }

        public int ClientId { get; set; }
    }
}
