using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var KaylasCar = new Car();
            KaylasCar.Make = "Buick";
            KaylasCar.Model = "Encore";
            KaylasCar.Year = 2017;
            KaylasCar.EngineNoise = "vroom, vroom";
            KaylasCar.HonkNoise = "BEEP BEEP";
            KaylasCar.IsDrivable = true;

            lot.ParkingLot.Add(KaylasCar);

            var SpencersCar = new Car()
            {
                Year = 2013,
                Make = "Chevy",
                Model = "Cruze",
                EngineNoise = "Clunk Clunk Tick Tick",
                HonkNoise = "Beep Beep",
                IsDrivable = true
            };

            lot.ParkingLot.Add(SpencersCar);

            var FutureCar = new Car(2022, "Tesla", "Model S", "...", "beep", true);

            lot.ParkingLot.Add(FutureCar);

            KaylasCar.MakeEngineNoise();


            SpencersCar.MakeEngineNoise();


            FutureCar.MakeEngineNoise();

            //From there create 3 cars in the Main() and then each time you create a car, 
            //do a Console.WriteLine() printing the current number of cars in the car lot
            Console.WriteLine($"The number of cars in the car lot: {CarLot.NumberOfCars}");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var Car in lot.ParkingLot)
            {
                Console.WriteLine($"Year:{Car.Year} Make: {Car.Make} Model:{Car.Model}");
            }
        }
    }
}
