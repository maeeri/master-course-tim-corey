using System;

namespace InheritanceMiniProject
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock--;
            Console.WriteLine("This vehicle has been purchased");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock--; 
            Console.WriteLine("The vehicle has been returned");
        }
    }
}
