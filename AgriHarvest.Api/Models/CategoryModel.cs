namespace AgriHarvest.Api.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public static Category DefaultCategory = new Category( 0, "Others");

        public static Category? GetCategoryById(int id, List<Category> categories)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public Category(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
