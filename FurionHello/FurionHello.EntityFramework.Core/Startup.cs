using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace FurionHello.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "FurionHello.Database.Migrations");
        }
    }
}