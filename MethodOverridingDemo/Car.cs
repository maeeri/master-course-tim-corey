using System;

namespace MethodOverridingDemo
{
    public abstract class  Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Car is starting");
        }

        public abstract void SetClock();
    }
}
