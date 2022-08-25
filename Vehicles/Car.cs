﻿using System;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }

        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}
