using AgriHarvest.Api.Models;

namespace AgriHarvest.Api.Services.ObjectServices.ProductServices
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product? GetById(int id);
    }
}
