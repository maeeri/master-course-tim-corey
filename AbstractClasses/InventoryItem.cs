namespace AbstractClasses
{
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; }
        //public decimal Price { get; set; }

        //public virtual decimal CalculateInventoryValue()
        //{
        //    return QuantityOnHand * Price;
        //}
    }
}
