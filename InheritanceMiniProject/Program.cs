using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, QuantityInStock = 5, ProductName = "Kia Optima" };
            var book = new BookModel { NumberOfPages = 100, QuantityInStock = 5, ProductName = "A Tale of Two Cities" };
            var excavator = new ExcavatorModel { QuantityInStock = 5, ProductName = "Bulldozer" };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(vehicle);
            purchasables.Add(book);

            Console.Write("Do you want to rent or purchase a vehicle? (rent/purchase) ");
            string rentalDecision = Console.ReadLine();
            
            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item? (yes/no) ");
                    string wantToRent = Console.ReadLine();
                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                    Console.Write("Do you want to return this item? (yes/no) ");
                    string wantToReturn = Console.ReadLine();
                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else if (rentalDecision.ToLower() == "purchase")
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item? (yes/no) ");
                    string wantToPurchase = Console.ReadLine();
                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            //inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "" });
            //inventory.Add(new BookModel { NumberOfPages = 100, ProductName = "" });
            Console.WriteLine("We are done");
            Console.ReadLine();
        }
    }
}
