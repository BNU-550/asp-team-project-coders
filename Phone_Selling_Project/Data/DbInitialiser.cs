using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Phone_Selling_Project.Models;

namespace Phone_Selling_Project.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            AddProducts(context);

            //AddPerson(context);


        }
       
        private static void AddProducts(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            var product = new Product[]
            {
                new Product{
                             ProductName="iPhone 11 Pro",
                             Description="Three cameras. Unlimited possibilities. Shoot amazing videos and photos with the Ultra Wide, " +
                                  "Wide and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR films and programmes on the Super Retina XDR display" +
                                  "the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR) and photography. " +
                                  "And get all-day battery life and a new level of water resistance. All in the first iPhone powerful enough to be called Pro.",
                             Price=1274.00m,
                             StockLevel=10,
                             MemoryStorage=512,
                             Colour=Colours.SpaceGrey,
                             ScreenSize=5.8,
                             Ram=4
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
                            }, 
            };
               
                 foreach(Product p in product)
                 {
                          context.Products.Add(p);
                 }
                context.SaveChanges();
            }

        private static void AddPerson(ApplicationDbContext context)
        {
            if (context.Persons.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person
                {
                    
                    PaymentID = 1,
                    AddressID = 1,
                    FirstName = "Louis",
                    LastName = "Symons",
                    Email = "Louis_Test@gmail.com",
                    MobileNumber = "07852589964",
                    isStaff = true,
                    DateOfBirth=DateTime.Parse("1992/06/15")
                }
            };

            foreach (Person p in people)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();
        }

    }
} 

             
            
        
    

