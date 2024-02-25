using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producr_ms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Total Store Worth");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

             if(choice == 1) 
                
                {
                    productManager.AddProduct();
                }
                else if (choice == 2)

                {
                    productManager.ShowProducts();
                }
               else if (choice == 3)

                {
                    productManager.TotalStoreWorth();
                }

            }
        }
    }

    class Product
    {
        public int ID;
        public string Name;
        public double Price;
        public string Category;
        public string BrandName;
        public string Country;
    }

    class ProductManager
    {
        public List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Product newProduct = new Product();

            Console.WriteLine("Enter Product ID:");
            newProduct.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Name:");
            newProduct.Name = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            newProduct.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Category:");
            newProduct.Category = Console.ReadLine();

            Console.WriteLine("Enter Product Brand Name:");
            newProduct.BrandName = Console.ReadLine();

            Console.WriteLine("Enter Product Country:");
            newProduct.Country = Console.ReadLine();

            products.Add(newProduct);

            Console.WriteLine("Product added successfully!");
        }

        public void ShowProducts()
        {
            Console.WriteLine("\nList of Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}, Brand Name: {product.BrandName}, Country: {product.Country}");
            }
            Console.WriteLine();
        }

        public void TotalStoreWorth()
        {
            double totalWorth = 0;

            foreach (var product in products)
            {
                totalWorth += product.Price;
            }

            Console.WriteLine($"Total Store Worth: {totalWorth}\n");
        }
    }
    
}
