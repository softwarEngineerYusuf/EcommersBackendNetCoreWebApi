
using ETicaretAPI.Infrastructure;
using ETicaretAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Servisleri DI container'a ekliyoruz
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           

            // Altyapı servislerini ekliyoruz
            builder.Services.AddInfrastructureServices(builder.Configuration);  

            var app = builder.Build();

            // HTTP request pipeline yapılandırmaları
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}