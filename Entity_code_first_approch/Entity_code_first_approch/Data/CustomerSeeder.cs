using Entity_code_first_approch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_code_first_approch.Data
{
    public class CustomerSeeder : DropCreateDatabaseIfModelChanges<CustomerDBContext>
    {
        protected override void Seed(CustomerDBContext context)
        {
            Product product1 = new Product()
            {
                ProductName = "phone",
                BrandName = "apple",
                Price = 100000
            };
            Product product2 = new Product()
            {
                ProductName = "TV",
                BrandName = "MI",
                Price = 50000
            };
            Product product3 = new Product()
            {
                ProductName = "headphone",
                BrandName = "JBL",
                Price = 1000
            };
            Product product4 = new Product()
            {
                ProductName = "refrigerator",
                BrandName = "LG",
                Price = 65000
            };
            Product product5 = new Product()
            {
                ProductName = "phone",
                BrandName = "samsung",
                Price = 12000
            };
            Product product6 = new Product()
            {
                ProductName = "speakers",
                BrandName = "JBl",
                Price = 60000
            };
            Product product7 = new Product()
            {
                ProductName = "pen",
                BrandName = "parker",
                Price = 700
            };
            Product product8 = new Product()
            {
                ProductName = "laptop",
                BrandName = "lenovo",
                Price = 51000
            };
            Product product9 = new Product()
            {
                ProductName = "microwave",
                BrandName = "LG",
                Price = 15000
            };
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);
            context.Products.Add(product5);
            context.Products.Add(product6);
            context.Products.Add(product7);
            context.Products.Add(product8);
            context.Products.Add(product9);



            //Customer cust1 = new Customer()
            //{
            //    FirstName = "Latika",
            //    LastName = "Malhotra",
            //    Gender = "Female",
            //    Phone = 965632123,
            //    Email = "l@tothenew.com",
            //    Street = "Vikas Puri",
            //    City = "New Delhi",
            //    State = "Delhi",
            //    Zip_Code = 110018,
            //    Orders = new List<Order>()
            //    {
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="12/01/2020",
            //            ProductID=1

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="12/01/2020",
            //            ProductID=2

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="12/01/2020",
            //            ProductID=3

            //        }
            //    }
            //};
            //Customer cust2 = new Customer()
            //{
            //    FirstName = "Megha",
            //    LastName = "Malhotra",
            //    Gender = "Female",
            //    Phone = 112632123,
            //    Email = "m@tothenew.com",
            //    Street = "Patel Nagar",
            //    City = "New Delhi",
            //    State = "Delhi",
            //    Zip_Code = 110098,
            //    Orders = new List<Order>()
            //    {
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="16/04/2011",
            //            ProductID=3

            //        },
            //        new Order()
            //        {
            //            OrderStatus=false,
            //            Date="19/03/2020",
            //            ProductID=6

            //        },
            //        new Order()
            //        {
            //            OrderStatus=false,
            //            Date="19/03/2020",
            //            ProductID=9

            //        }
            //    }
            //};
            //Customer cust3 = new Customer()
            //{
            //    FirstName = "Deepak",
            //    LastName = "Kalra",
            //    Gender = "male",
            //    Phone = 987654561,
            //    Email = "d@tothenew.com",
            //    Street = "Rohini",
            //    City = "New Delhi",
            //    State = "Delhi",
            //    Zip_Code = 110089,
            //    Orders = new List<Order>()
            //    {
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="11/02/2019",
            //            ProductID=8

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="13/03/2019",
            //            ProductID=7

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="14/01/2020",
            //            ProductID=6

            //        }
            //    }
            //};
            //Customer cust4 = new Customer()
            //{
            //    FirstName = "Dimple",
            //    LastName = "Duggle",
            //    Gender = "Female",
            //    Phone = 123454561,
            //    Email = "di@tothenew.com",
            //    Street = "karol bagh",
            //    City = "New Delhi",
            //    State = "Delhi",
            //    Zip_Code = 110019,
            //    Orders = new List<Order>()
            //    {
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="11/02/2019",
            //            ProductID=5

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="13/03/2019",
            //            ProductID=4

            //        },
            //        new Order()
            //        {
            //            OrderStatus=true,
            //            Date="14/01/2020",
            //            ProductID=3

            //        }
            //    }
            //};

            //context.Customers.Add(cust1);
            //context.Customers.Add(cust2);
            //context.Customers.Add(cust3);
            //context.Customers.Add(cust4);


            base.Seed(context);
        }
    }
}