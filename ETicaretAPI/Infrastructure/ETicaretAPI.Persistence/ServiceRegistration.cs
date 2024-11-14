using ETicaretAPI.Infrastructure;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
          
            services.AddDbContext<ETicaretDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ETicaretDbConnection"))); 

            
            

            return services;
        }
    }
}
// Service ve Interface kayıtları
//services.AddScoped<IYourEntityService, YourEntityService>();
//services.AddScoped<IAnotherService, AnotherService>();
// Yeni servis ve interface kayıtlarını buraya ekleyin