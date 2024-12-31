using System.Collections.Generic;

namespace InheritanceDemo
{
    internal partial class Program
    {
        public class  SmartPhone : CellPhone
        {
            public List<string> Apps { get; set; }
            public void ConnectToInternet()
            {

            }
        }
    }
}
