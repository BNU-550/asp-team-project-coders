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
                             MemoryStorage= "512",
                             Colour=Colours.SpaceGrey,
                             ScreenSize=5.8,
                             Ram= "4"
                                },
                new Product{
                             ProductName = "iPhone 11 Pro",
                             Description = "Three cameras. Unlimited possibilities. Shoot amazing videos and photos with the Ultra Wide, " +
                                          "Wide and Telephoto cameras. Capture your best low-light photos with Night mode. Watch HDR films and programmes on the Super Retina XDR display" +
                                          "the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR) and photography. " +
                                          "And get all-day battery life and a new level of water resistance. All in the first iPhone powerful enough to be called Pro.",
                             Price = 1274.00m,
                             StockLevel = 5,
                             MemoryStorage = "512",
                             Colour = Colours.Gold,
                             ScreenSize = 5.8,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 12 Pro Max",
                             Description = "iPhone 12 Pro Max. Superfast 5G. A14 Bionic, the fastest chip in a smartphone. Pro camera system for unbelievable low-light photography. " +
                             "And a larger Super Retina XDR display. It's a huge leap forward.Beautifully bright 6.7-inch Super Retina XDR display with ceramic shield with 4x better drop performance.",
                             Price = 1249.00m,
                             StockLevel = 3,
                             MemoryStorage = "512",
                             Colour = Colours.Blue,
                             ScreenSize = 6.7,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 13 Pro Max",
                             Description = "Oh. So. Pro. Even more Pro. A total Pro. iPhone 13 Pro Max comes with the biggest Pro cameras system upgrade ever. " +
                             "The colourful, sharper and brighter 6.7-inch Super Retina XDR display with ProMotion for faster, more responsive feel. A15 Bionic chip, " +
                             "the world's fastest smartphone chip for lightning-fast performance. Durable design and the best battery life ever in an iPhone.",
                             Price = 1149.00m,
                             StockLevel = 2,
                             MemoryStorage = "256",
                             Colour = Colours.Gold,
                             ScreenSize = 6.7,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 13",
                             Description = "Your new superpower. All-out standout. The iPhone 13 features the most advanced dual-camera system ever on an iPhone. " +
                             "The colourful, sharper and brighter 6.1-inch Super Retina XDR display and durable flat-edge design with Ceramic Shield. A15 Bionic chip, " +
                             "the world's fastest smartphone chip for lightning-fast performance. A big leap in battery life.",
                             Price = 879.00m,
                             StockLevel = 1,
                             MemoryStorage = "256",
                             Colour = Colours.Starlight,
                             ScreenSize = 6.1,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 13",
                             Description = "Your new superpower. All-out standout. The iPhone 13 features the most advanced dual-camera system ever on an iPhone. " +
                             "The colourful, sharper and brighter 6.1-inch Super Retina XDR display and durable flat-edge design with Ceramic Shield. A15 Bionic chip, " +
                             "the world's fastest smartphone chip for lightning-fast performance. A big leap in battery life.",
                             Price = 879.00m,
                             StockLevel = 2,
                             MemoryStorage = "256",
                             Colour = Colours.Red,
                             ScreenSize = 6.1,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 12",
                             Description = "iPhone 12 pushes everything forward with superfast 5G. A14 Bionic, the fastest chip in a smartphone. A new dual-camera system. " +
                             "And a beautiful Super Retina XDR display, so you can see everything in vivid detail.",
                             Price = 829.00m,
                             StockLevel = 5,
                             MemoryStorage = "256",
                             Colour = Colours.White,
                             ScreenSize = 6.1,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 11",
                             Description = "Just the right amount of everything. Shoot 4K videos, beautiful portraits and sweeping landscapes with the all-new dual-camera system. " +
                             "Capture your best low-light photos with Night mode. See true-to-life colour in your photos, videos and games on the 6.1-inch Liquid Retina display. " +
                             "Experience unprecedented performance with A13. Bionic for gaming, augmented reality (AR) and photography. Do more and charge less with all-day battery life.",
                             Price = 639.00m,
                             StockLevel = 2,
                             MemoryStorage = "256",
                             Colour = Colours.Purple,
                             ScreenSize = 6.1,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 13 mini",
                             Description = "Your new superpower. All-out standout. iPhone 13 mini. So mini, so amazing. Featuring the most advanced dual-camera system ever on iPhone. " +
                             "The colourful, sharper and brighter 5.4-inch Super Retina XDR display and durable flat-edge design with Ceramic Shield. A15 Bionic chip, " +
                             "the world's fastest smartphone chip for lightning-fast performance. A big leap in battery life.",
                             Price = 779.00m,
                             StockLevel = 1,
                             MemoryStorage = "256",
                             Colour = Colours.Blue,
                             ScreenSize = 6.1,
                             Ram = "4"
                            },

                new Product{
                             ProductName = "iPhone 11 Pro",
                             Description = "Three cameras. Unlimited possibilities. Shoot amazing videos and photos with the Ultra Wide, Wide and Telephoto cameras. Capture your best low-light photos with Night mode. " +
                             "Watch HDR films and programmes on the Super Retina XDR display — the brightest iPhone display yet. Experience unprecedented performance with A13 Bionic for gaming, augmented reality (AR) " +
                             "and photography. And get all-day battery life and a new level of water resistance. All in the first iPhone powerful enough to be called Pro.",
                             Price = 1274.00m,
                             StockLevel = 12,
                             MemoryStorage = "256",
                             Colour = Colours.MidnightGreen,
                             ScreenSize = 5.8,
                             Ram = "4"
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

             
            
        
    

