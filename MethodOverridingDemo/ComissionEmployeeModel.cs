namespace MethodOverridingDemo
{
    public class ComissionEmployeeModel : EmployeeModel
    {
        public decimal ComissionAmount { get; set; }

        public override decimal GetPayCheck(decimal hoursWorked)
        {
            decimal initialPay = base.GetPayCheck(hoursWorked);
            return initialPay + ComissionAmount;
        }
    }
}
