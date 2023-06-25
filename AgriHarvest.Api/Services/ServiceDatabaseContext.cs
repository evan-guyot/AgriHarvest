using AgriHarvest.Api.Services.ObjectServices.ProductServices.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AgriHarvest.Api.Services
{
    public static class ServiceDatabaseContext
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services)
        {
            var callbackSettings = (DbContextOptionsBuilder options) =>
            {
                //Consommation de la bdd
                options.UseSqlServer("Data Source=PC-EVAN\\SQLEXPRESS;Initial Catalog=agriharvest;Integrated Security=True;Encrypt=False;");
            };

            services.AddDbContext<ProductContext>(callbackSettings);

            return services;
        }
    }
}
