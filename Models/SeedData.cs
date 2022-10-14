using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Robot Vacuum Cleaner",
                        Description = "White Colour 2000W",
                        Category = "Home & Kitchen",
                        Price = 249,
                        Image = "product1.png"
                    },
                new Product
                    {
                        Name = "Smart Watch",
                        Description = "Fashionable Android Smart Watch",
                        Category = "Electronics",
                        Price = 149,
                        Image = "product2.png"
                    },
                new Product
                    {
                        Name = "Toy Dinosaurus",
                        Description = "Gift toy for kids",
                        Category = "Toys",
                        Price = 29,
                        Image = "product3.png"
                    },
                new Product
                    {
                        Name = "Chair",
                        Description = "White colour chair",
                        Category = "Home Decor",
                        Price = 119,
                        Image = "product4.png"
                    },
                new Product
                    {
                        Name = "Kettle",
                        Description = "1.25L metallic",
                        Category = "Kitchen",
                        Price = 49,
                        Image = "product5.png"
                    },
                new Product
                    {
                        Name = "Kids Bedside Table",
                        Description = "2 draw bedside table",
                        Category = "Furniture",
                        Price = 299,
                        Image = "product6.png"
                    },
                new Product
                    {
                        Name = "Tea Set",
                        Description = "Ceramic handmade tea set",
                        Category = "Kitchen",
                        Price = 199,
                        Image = "product7.png"
                    },
                new Product
                    {
                        Name = "Watch",
                        Description = "Wrist watch",
                        Category = "Accessories",
                        Price = 129,
                        Image = "product8.png"
                    },
                
                new Product
                    {
                        Name = "Robot Vacuum Cleaner",
                        Description = "White Colour 2000W",
                        Category = "Home & Kitchen",
                        Price = 249,
                        Image = "product1.png"
                    }
                
                
                );
                context.SaveChanges();
            }
        }
    }
}
/*
                new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    }
                */