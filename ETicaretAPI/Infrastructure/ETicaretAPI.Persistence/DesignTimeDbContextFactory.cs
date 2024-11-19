using ETicaretAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{                 
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretDbContext>  //bu sınıf powershell ile clı üzerinden miration yapmak için ayarlandı.
    {
        public ETicaretDbContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");


            DbContextOptionsBuilder<ETicaretDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(configurationManager.GetConnectionString("ETicaretDbConnection"));
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
