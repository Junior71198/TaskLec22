using Microsoft.EntityFrameworkCore;
using TaskLec22.Data;

namespace TaskLec22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStores529Context _context = new BikeStores529Context();

            #region 1-List all customers' first and last names along with their email addresses. 
            //var customers = _context.Customers.Select(c => new
            //{
            //    c.FirstName,
            //    c.LastName,
            //    c.Email
            //});
            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"{item.FirstName},{item.LastName},{item.Email}");
            //}

            #endregion

            #region 2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3). 
            //var orders = _context.Orders.Include(o => o.Staff).Where(o => o.StaffId == 3);
            //foreach (var item in orders) 
            //{ Console.WriteLine($"{item.OrderId},{item.OrderItems},{item.StaffId}");}

            #endregion

            #region 3- Get all products that belong to a category named "Mountain Bikes". 

            //var products = _context.Products.Include(p=>p.Category).Where(p=>p.Category.CategoryName == "Mountain Bikes");
            //foreach (var item in products)
            //{ Console.WriteLine($"{item.ProductId},{item.ProductName},{item.Category.CategoryName}"); }

            #endregion

            #region 4-Count the total number of orders per store. 
            //var ordersInStores = _context.Orders.GroupBy(o => o.StoreId).Select(o=> new
            //{
            //    StoreId = o.Key,
            //    TotalOrders = o.Count()
            //});

            //foreach (var item in ordersInStores)
            //{
            //    Console.WriteLine($"{item.StoreId}: {item.TotalOrders}");
            //}
            #endregion

            #region 5- List all orders that have not been shipped yet (shipped_date is null). 

            //var orders = _context.Orders.Where(o=>o.ShippedDate == null);
            //foreach(var item in orders)
            //{
            //    Console.WriteLine($"{item.OrderId}, {item.OrderDate} , {item.ShippedDate}");
            //}

            #endregion

            #region 6- Display each customer’s full name and the number of orders they have placed. 
            //var custmersOrders = _context.Customers.Include(c => c.Orders).Select(c => new
            //{
            //    c.FirstName,
            //    c.LastName,
            //   TotalOrders = c.Orders.Count
            //});
            //foreach (var item in custmersOrders)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}: {item.TotalOrders}");
            //}


            #endregion

            #region 7- List all products that have never been ordered (not found in order_items). 

            //var productsNotOredered = _context.Products.Where(p=>p.OrderItems==null || p.OrderItems.Count == 0);

            //foreach (var item in productsNotOredered)
            //{
            //    Console.WriteLine($"{item.ProductId}, {item.ProductName}");
            //}

            #endregion

            #region 8- Display products that have a quantity of less than 5 in any store stock. 
            //var productsless = _context.Products.Include(p => p.Stocks).Where(p => p.Stocks.Any(s => s.Quantity < 5));

            //foreach (var item in productsless)
            //{
            //    Console.WriteLine($"{item.ProductId}, {item.ProductName}");
            //}

            #endregion

            #region 9- Retrieve the first product from the products table. 
            //var firstp = _context.Products.FirstOrDefault();
            //Console.WriteLine($"{firstp.ProductId}, {firstp.ProductName}");

            #endregion

            #region 10- Retrieve all products from the products table with a certain model year

            //var productsyear = _context.Products.Where(p => p.ModelYear == 2018);
            //foreach (var item in productsyear)
            //{
            //    Console.WriteLine($"{item.ProductId}, {item.ProductName}, {item.ModelYear}");
            //}

            #endregion

            #region 11- Display each product with the number of times it was ordered.

            //var productsTime= _context.Products.Include(p => p.OrderItems).Select(p => new
            //{
            //    p.ProductName,
            //    OrderCount = p.OrderItems.Count
            //});

            //foreach(var item in productsTime)
            //{
            //    Console.WriteLine($"{item.ProductName}: {item.OrderCount}");
            //}


            #endregion

            #region 12- Count the number of products in a specific category. 
            //var productCat = _context.Products.Include(p => p.Category).Where(p => p.Category.CategoryName == "Cruisers Bicycles")
            //    .Count();
            //Console.WriteLine(productCat);
            #endregion

            #region 13- Calculate the average list price of products. 

            //var productAvg =_context.Products.Average(p=>p.ListPrice);
            //Console.WriteLine(productAvg);

            #endregion

            #region 14- Retrieve a specific product from the products table by ID. 

            //var productId = _context.Products.Find(10);
            //            Console.WriteLine($"{productId.ProductName}");

            #endregion

            #region 15- List all products that were ordered with a quantity greater than 3 in any order. 

            //var productsOrderMore =_context.Products.Include(p => p.OrderItems).Where(p => p.OrderItems.Any(oi => oi.Quantity > 3));

            //foreach (var item in productsOrderMore)
            //{
            //    Console.WriteLine($"{item.ProductId}, {item.ProductName}");
            //}
            #endregion

            #region 16- Display each staff member’s name and how many orders they processed. 
            //var stafforders =_context.Staffs.Include(s => s.Orders).Select(s => new
            //{
            //    s.FirstName,
            //    s.LastName,
            //    OrderCount = s.Orders.Count
            //});

            //foreach (var item in stafforders)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}: {item.OrderCount}");
            //}

            #endregion

            #region 17- List active staff members only (active = true) along with their phone numbers. 

            //var staffactive = _context.Staffs.Where(s=>s.Active==1).Select(s => new
            //{
            //    s.FirstName,
            //    s.LastName,
            //    s.Phone
            //});

            //foreach(var item in staffactive)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Phone}");
            //}

            #endregion

            #region 18- List all products with their brand name and category name. 

            //var productsBrand = _context.Products.Include(p => p.Brand).Include(p => p.Category).Select(p => new
            //{
            //    p.ProductName,
            //    BrandName = p.Brand.BrandName,
            //    CategoryName = p.Category.CategoryName
            //});

            //foreach (var item in productsBrand)
            //{
            //    Console.WriteLine($"{item.ProductName}, {item.BrandName}, {item.CategoryName}");
            //}   

            #endregion

            #region 19- Retrieve orders that are completed. 

            // Assume OrderStatus = 3 means OrderComplete




            //var orderComplete = _context.Orders.Where(o => o.OrderStatus == 3);

            //foreach (var item in orderComplete)
            //{
            //    Console.WriteLine($"{item.OrderId}, {item.OrderStatus}");
            //}


            #endregion

            #region 20- List each product with the total quantity sold (sum of quantity from order_items). 

            //var productsQuantity = _context.Products.Include(p => p.OrderItems).Select(p => new
            //{
            //    p.ProductName,
            //    Total = p.OrderItems.Sum(oi => oi.Quantity)
            //});

            //foreach (var item in productsQuantity)
            //{
            //    Console.WriteLine($"{item.ProductName}: {item.Total}");
            //}

            #endregion


        }

    }

    
}
