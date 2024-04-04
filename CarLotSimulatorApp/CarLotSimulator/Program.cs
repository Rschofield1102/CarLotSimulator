using System;

namespace CarLotSimulator
{
    class Program
    {

            static void Main(string[] args)
            {
                
                Car myCar = new Car() { Year = 2001, Make = "Toytoa", Model = "Corolla", EngineNoise = "kinda loud", HonkNoise = "LOUDDD", IsDriveable = true};

                Car familyCar = new Car() { Year = 2011, Make = "Toytoa", Model = "Tacoma", EngineNoise = "very quiet", HonkNoise = "beep beep", IsDriveable = true };

                Car myTruck = new Car() { Year = 2022, Make = "Ford", Model = "Raptor", EngineNoise = "very quiet", HonkNoise = "beeps", IsDriveable = true };

                
                myCar.MakeEngineNoise();
                familyCar.MakeHonkNoise();
                myTruck.MakeHonkNoise();


            //TODO

            //DONE---Create a seperate class file called Car
            //DONECar shall have the following properties: ((int)Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONECar shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //DONEENow that the Car class is created we can instanciate 3 new cars
            //DONEESet the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console








        }

        

    }
}
