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

            AddAddress(context);

            AddPayment(context);

            AddPerson(context);

            AddReview(context);



        }

        private static void AddReview(ApplicationDbContext context)
        {
            if (context.Reviews.Any())
            {
                return;
            }

            var reviews = new Review[]
            {
                new Review
                {
                     ProductID=1,
                     PersonID=1,  
                     Text="Excellent"
                },

                new Review
                {
                    ProductID=2,
                    PersonID=2,
                    Text="Speedy Service"
                },

                new Review
                {
                    ProductID=3,
                    PersonID=3,
                    Text="Good selection of products"
                },

                new Review
                {
                    ProductID=4,
                    PersonID=4,
                    Text="Arrvied in good time"
                },

                new Review
                {
                    ProductID=5,
                    PersonID=5,
                    Text="Good customer service"
                },

                new Review
                {
                    ProductID=6,
                    PersonID=6,
                    Text="Fast delivery"
                },

                new Review
                {
                    ProductID=7,
                    PersonID=7,
                    Text="Good value for money"
                },

                new Review
                {
                    ProductID=8,
                    PersonID=8,
                    Text="Good service"
                },

                new Review
                {
                    ProductID=9,
                    PersonID=9,
                    Text="Arrived as expected"
                },

                new Review
                {
                    ProductID=10,
                    PersonID=10,
                    Text="Great service"
                },
            };

            foreach (Review r in reviews)
            {
                context.Reviews.Add(r);
            }
            context.SaveChanges();
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
                },

                new Person
                {

                    PaymentID = 2,
                    AddressID = 2,
                    FirstName = "Joe",
                    LastName = "Smith",
                    Email = "Joe_Smith@gmail.com",
                    MobileNumber = "07452589964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1998/04/12")
                },

                new Person
                {

                    PaymentID = 3,
                    AddressID = 3,
                    FirstName = "Sam",
                    LastName = "Rickard",
                    Email = "Sam_R@gmail.com",
                    MobileNumber = "07454589964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1996/08/12")
                },

                new Person
                {

                    PaymentID = 4,
                    AddressID = 4,
                    FirstName = "Phi",
                    LastName = "Brown",
                    Email = "Phil_Brown@gmail.com",
                    MobileNumber = "07452589964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1988/04/12")
                },

                new Person
                {

                    PaymentID = 5,
                    AddressID = 5,
                    FirstName = "Max",
                    LastName = "Tester",
                    Email = "Max_Tester@gmail.com",
                    MobileNumber = "07852589955",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1992/06/18")
                },

                new Person
                {

                    PaymentID = 6,
                    AddressID = 6,
                    FirstName = "Timmy",
                    LastName = "Russell",
                    Email = "Timmy@gmail.com",
                    MobileNumber = "07852589486",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1997/06/15")
                },

                new Person
                {

                    PaymentID = 7,
                    AddressID = 7,
                    FirstName = "Karl",
                    LastName = "Matthews",
                    Email = "Karl@gmail.com",
                    MobileNumber = "07812389964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1985/08/15")
                },

                new Person
                {

                    PaymentID = 8,
                    AddressID = 8,
                    FirstName = "Mike",
                    LastName = "Peevor",
                    Email = "Mike@gmail.com",
                    MobileNumber = "07485589964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1952/06/15")
                },

                new Person
                {

                    PaymentID = 9,
                    AddressID = 9,
                    FirstName = "James",
                    LastName = "Arns",
                    Email = "James@gmail.com",
                    MobileNumber = "07785589964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1982/09/15")
                },

                new Person
                {

                    PaymentID = 10,
                    AddressID = 10,
                    FirstName = "Jay",
                    LastName = "Crock",
                    Email = "Jaycc@gmail.com",
                    MobileNumber = "07852145964",
                    isStaff = false,
                    DateOfBirth=DateTime.Parse("1998/04/18")
                },
            };

            

            foreach (Person p in people)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();
        }

        private static void AddAddress(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address
                {
                    HouseNameNumber = "19",
                    PostCode = "TR151NA"
                    
                },

                new Address
                {
                    HouseNameNumber = "25",
                    PostCode = "TR13PD"

                },

                new Address
                {
                    HouseNameNumber = "89",
                    PostCode = "TR182BN"

                },

                new Address
                {
                    HouseNameNumber = "50",
                    PostCode = "TR32NA"

                },

                new Address
                {
                    HouseNameNumber = "58",
                    PostCode = "TR32NA"

                },

                new Address
                {
                    HouseNameNumber = "74",
                    PostCode = "TR32NA"

                },

                new Address
                {
                    HouseNameNumber = "69",
                    PostCode = "TR1449TG"

                },

                new Address
                {
                    HouseNameNumber = "19",
                    PostCode = "TR32NA"

                },

                new Address
                {
                    HouseNameNumber = "70",
                    PostCode = "TR164BQ"

                },

                new Address
                {
                    HouseNameNumber = "85",
                    PostCode = "TR164BQ"

                },
            };

            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();
        }

        private static void AddPayment(ApplicationDbContext context)
        {
            if (context.Payments.Any())
            {
                return;
            }

            var payments = new Payment[]
            {
                new Payment
                {
                    ExpiryMonth = 08,
                    ExpiryYear = 17,
                    CardNumber = 123456789,
                    SecurityCode = 123

                },

                new Payment
                {
                    ExpiryMonth = 06,
                    ExpiryYear = 19,
                    CardNumber = 123456755,
                    SecurityCode = 456

                },

                new Payment
                {
                    ExpiryMonth = 10,
                    ExpiryYear = 23,
                    CardNumber = 123456856,
                    SecurityCode = 789

                },

                new Payment
                {
                    ExpiryMonth = 08,
                    ExpiryYear = 25,
                    CardNumber = 123456789,
                    SecurityCode = 123

                },

                new Payment
                {
                    ExpiryMonth = 09,
                    ExpiryYear = 24,
                    CardNumber = 123455689,
                    SecurityCode = 485

                },

                new Payment
                {
                    ExpiryMonth = 07,
                    ExpiryYear = 24,
                    CardNumber = 123456825,
                    SecurityCode = 485

                },

                new Payment
                {
                    ExpiryMonth = 02,
                    ExpiryYear = 22,
                    CardNumber = 123456145,
                    SecurityCode = 654

                },

                new Payment
                {
                    ExpiryMonth = 05,
                    ExpiryYear = 23,
                    CardNumber = 123456652,
                    SecurityCode = 325

                },

                new Payment
                {
                    ExpiryMonth = 09,
                    ExpiryYear = 24,
                    CardNumber = 123456485,
                    SecurityCode = 524

                },

                new Payment
                {
                    ExpiryMonth = 02,
                    ExpiryYear = 22,
                    CardNumber = 12345648,
                    SecurityCode = 325

                },
            };

            foreach (Payment p in payments)
            {
                context.Payments.Add(p);
            }
            context.SaveChanges();
        }

    }
} 

             
            
        
    

