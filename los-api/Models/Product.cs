namespace los_api.Models
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public string imageUrl { get; set; }

        public decimal? price { get; set; }
    }
}