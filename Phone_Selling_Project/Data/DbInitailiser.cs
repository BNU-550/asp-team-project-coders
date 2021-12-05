using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Phone_Selling_Project.Models;

namespace Phone_Selling_Project.Data
{
    public static class DbInitailiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddProducts(context);
        }

        private static void AddProducts(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            var products = new Product[]
            {
                new Product{
                ProductName = "iPhone 11 Pro",
                Description = "Three cameras. Unlimited possibilities. Shoot amazing videos and photos with the Ultra Wide, " +
                              "Wide and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR films and programmes on the Super Retina XDR display" +
                              "the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR) and photography. " +
                              "And get all-day battery life and a new level of water resistance. All in the first iPhone powerful enough to be called Pro.",
                Price = 1274.00m,
                StockLevel = 10,
                MemoryStorage = 512,
                Colour = Colours.SpaceGrey,
                ScreenSize = 5.8,
                Ram = 4
            },
            new Product{
                ProductName = "iPhone 10 Pro",
                Description = "Three cameras. Unlimited possibilities. Shoot amazing videos and photos with the Ultra Wide, " +
                              "Wide and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR films and programmes on the Super Retina XDR display" +
                              "the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR) and photography. " +
                              "And get all-day battery life and a new level of water resistance. All in the first iPhone powerful enough to be called Pro.",
                Price = 800.00m,
                StockLevel = 1,
                MemoryStorage = 512,
                Colour = Colours.SpaceGrey,
                ScreenSize = 5.8,
                Ram = 4
                }
            };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    } 

             
            
        
    

