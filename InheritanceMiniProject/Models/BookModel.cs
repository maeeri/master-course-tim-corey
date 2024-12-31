using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }
        public void Purchase()
        {
            QuantityInStock--;
            Console.WriteLine("This book has been purchased");
        }
    }
}
