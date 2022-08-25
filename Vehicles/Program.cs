using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Airplane journey");
            Airplane airplane = new Airplane();
            airplane.StartEngine("Contact");
            airplane.TakeOff();
            airplane.Drive();
            airplane.Land();
            airplane.StopEngine("Whirr");

            Console.WriteLine("\nCar Journey");
            Car car = new Car();
            car.StartEngine("Brm brm");
            car.Accelerate();
            car.Drive();
            car.Brake();
            car.StopEngine("Phut phut");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
