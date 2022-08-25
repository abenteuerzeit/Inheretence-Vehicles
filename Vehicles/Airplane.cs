using System;

namespace Vehicles
{
    internal class Airplane : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }
    }
}
