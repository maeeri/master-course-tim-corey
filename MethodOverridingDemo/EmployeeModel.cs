namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPayCheck(decimal hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
