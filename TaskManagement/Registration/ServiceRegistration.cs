using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskManagement.Models;

namespace TaskManagement.Registration
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TaskManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        }
    }
}
