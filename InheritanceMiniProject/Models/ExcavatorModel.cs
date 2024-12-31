using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I'm digging");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock++;
            Console.WriteLine("The excavator has been returned");
        }
    }
}
