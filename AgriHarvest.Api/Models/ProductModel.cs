namespace AgriHarvest.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public Category Category { get; set; } = Category.DefaultCategory;

        // Full constructor
        public Product(int? id, string name, double price, string description, Category? category)
        {
            Id = id == null ? -1 : (int) id;
            Name = name;
            Price = price;
            Description = description;
            Category = category == null ? Category.DefaultCategory : category;
        }

        // Default
        public Product() : this(null, "Product Name", 0, "Product Description", Category.DefaultCategory)
        {

        }
    }
}
