namespace los_api.Models
{
    public class ProductStock
    {
        public int productId { get; set; }

        public string name { get; set; }

        public string imageUrl { get; set; }

        public decimal? pricePerEach { get; set; }

        public int amount { get; set; }
    }
}
