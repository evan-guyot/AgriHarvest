using AgriHarvest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriHarvest.Api.Services.ObjectServices.ProductServices.Contexts
{
    public class ProductContextService : IProductService
    {
        private readonly ProductContext context;

        public ProductContextService(ProductContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            var query = this.context.Products.AsNoTracking();

            return query.ToList();
        }

        public Product? GetById(int id)
        {
            var query = this.context.Products.AsNoTracking()
                            .Where(p => p.Id == id);

            return query.FirstOrDefault();
        }
    }
}
