using System;

namespace MethodOverridingDemo
{
    public class Tesla : Car
    {
        public override void SetClock()
        {
            throw new NotImplementedException();
        }
    }
}
