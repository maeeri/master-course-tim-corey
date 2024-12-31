using System;

namespace MethodOverridingDemo
{
    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Clock is set");
        }
    }
}
