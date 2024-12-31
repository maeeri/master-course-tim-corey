namespace InheritanceDemo
{
    internal partial class Program
    {
        public class CellPhone : Phone
        {
            public string Carrier { get; set; }
            public void SendText(string number, string message)
            {

            }
        }
    }
}
