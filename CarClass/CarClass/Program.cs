using System.Security.Cryptography.X509Certificates;

namespace CarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "I7";
            car1.CurrentFuel = 30;
            car1.FuelFor1KM = 4;
            car1.Millage = 10;

            car1.Drive(7);

            car1.FuelFor1KM = 10;
            car1.Drive(7);

        }
    }
}
