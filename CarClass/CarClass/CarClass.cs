
namespace CarClass
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1KM;
        public double Millage;
        public  void Drive (int km) 
        {
            
            if (CurrentFuel>=FuelFor1KM*km)
            {
                Console.WriteLine(Millage += FuelFor1KM * km);

            }
            else 
            {
                Console.WriteLine("Benzin kifayet etmir." );
            }

        }






    }
}
