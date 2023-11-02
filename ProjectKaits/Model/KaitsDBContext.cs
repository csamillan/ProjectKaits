using Microsoft.EntityFrameworkCore;

namespace ProjectKaits.Model
{
    public class KaitsDBContext : DbContext
    {
        public KaitsDBContext() { }

        public KaitsDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Client> clientsInits = new List<Client>();

            clientsInits.Add(new Client
            {
                ClientId = 1,
                ClientName = "Carlos Anthony Samillan Montalvan",
                DNI = "72842671"
            });

            clientsInits.Add(new Client
            {
                ClientId = 2,
                ClientName = "Marlon Montalvo",
                DNI = "16845975"
            });

            clientsInits.Add(new Client
            {
                ClientId = 3,
                ClientName = "Gustavo Culqui",
                DNI = "35698574"
            });

            modelBuilder.Entity<Client>(Client =>
            {
                Client.HasKey(p => p.ClientId);

                Client.Property(p => p.ClientName)
                                        .IsRequired()
                                        .HasMaxLength(120);

                Client.Property(p => p.DNI)
                                        .IsRequired()
                                        .HasMaxLength(8);

                Client.HasData(clientsInits);

            });

            List<Product> productsInits = new List<Product>();

            productsInits.Add(new Product
            {
                ProductId = 1,
                ProductDescripcion = "Leche Gloria 600ml"
            });

            productsInits.Add(new Product
            {
                ProductId = 2,
                ProductDescripcion = "Frugos del Valle 1L"
            });

            productsInits.Add(new Product
            {
                ProductId = 3,
                ProductDescripcion = "Galletas Oreo"
            });

            productsInits.Add(new Product
            {
                ProductId = 4,
                ProductDescripcion = "Gaseosa Inka Kola 1L"
            });

            productsInits.Add(new Product
            {
                ProductId = 5,
                ProductDescripcion = "Aceite Primor 1L"
            });

            modelBuilder.Entity<Product>(Product =>
            {
                Product.HasKey(p => p.ProductId);

                Product.Property(p => p.ProductDescripcion)
                                        .IsRequired()
                                        .HasMaxLength(150);

                Product.HasData(productsInits);

            });

            modelBuilder.Entity<Order>(Order =>
            {
                Order.HasKey(p => p.OrderId);

                Order.Property(p => p.TotalPrice)
                                        .HasPrecision(14, 2)
                                        .IsRequired();

                Order.Property(p => p.OrderId)
                                        .IsRequired();

                Order.Property(p => p.DateOrder)
                                        .IsRequired();
            });

            modelBuilder.Entity<OrderDetail>(OrderDetail =>
            {
                OrderDetail.HasKey(p => p.OrderDetailId);

                OrderDetail.Property(p => p.DetailDescripcion)
                                        .IsRequired()
                                        .HasMaxLength(150);

                OrderDetail.Property(p => p.Quantity)
                                        .IsRequired();

                OrderDetail.Property(p => p.UnitPrice)
                                        .HasPrecision(14, 2)
                                        .IsRequired();

                OrderDetail.Property(p => p.ProductId)
                                        .IsRequired();
            });
        }
    }
}
