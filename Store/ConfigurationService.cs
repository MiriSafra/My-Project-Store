using Store.service.BL;
using Store.service.DAL;

namespace Store
{
    public static class ConfigurationService
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

        }
    }
}
