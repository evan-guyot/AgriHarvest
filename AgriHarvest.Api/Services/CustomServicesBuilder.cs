using AgriHarvest.Api.Services.ObjectServices.ProductServices;
using AgriHarvest.Api.Services.ObjectServices.ProductServices.Contexts;

namespace AgriHarvest.Api.Services
{
    public static class CustomServicesBuilder
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductContextService>();

            return services;
        }
    }
}
