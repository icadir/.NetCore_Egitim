
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Core.EntityFrameWork.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Name = "Product 1", Description = "Product Desc", Price = 100, Category = "Kategory 1 " },
                    new Product() { Name = "Product 2", Description = "Product Desc", Price = 100, Category = "Kategory 1 " },
                    new Product() { Name = "Product 3", Description = "Product Desc", Price = 100, Category = "Kategory 1 " }
                    );
                context.SaveChanges();
            }

        }
    }
}
