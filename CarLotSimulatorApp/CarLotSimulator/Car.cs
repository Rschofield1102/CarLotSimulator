using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine("SOLD CAR");
            Console.WriteLine( $"{Year},{Make},{Model},{EngineNoise},{HonkNoise},{IsDriveable}");
            Console.WriteLine();
           

            
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine("Car FOR SALE");
            Console.WriteLine( $"{Year},{Make},{Model},{EngineNoise},{HonkNoise},{IsDriveable}");
            Console.WriteLine();
        }



        public Car ()
        {
            CarLot.numberOfCars++;

            
        }




    }

	
}

