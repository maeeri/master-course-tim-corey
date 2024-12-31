namespace AbstractClasses
{
    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        //public override decimal CalculateInventoryValue()
        //{
        //    return QuantityOnHand * Price * 1.2m;
        //}
    }
}
