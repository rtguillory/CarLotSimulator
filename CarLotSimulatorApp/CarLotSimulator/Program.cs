using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            CarLot carLot = new CarLot();   


            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Year =  2020;
            car1.Model = "Escape";
            car1.IsDriveable = false;

            car1.MakeEngineNoise("shake, rattle, and boom");
            car1.MakeHonkNoise("swish");

            Console.WriteLine(car1.ToString());
            carLot.Cars.Add(car1);

            Car car2 = new Car() { HonkNoise = "bomm bomm", IsDriveable = true, Model = "Kia", EngineNoise = "quiet hum", Make = "Sorrento", Year = 2023 };
            Console.WriteLine(car2);
            car2.MakeEngineNoise("tick tick");
            car2.MakeHonkNoise("honk honk");
            Console.WriteLine(car2);
            carLot.Cars.Add(car2);

            Car car3 = new Car() 
            { 
                Model = "Honda", 
                Make = "CRV", 
                Year = 2018, 
                IsDriveable= true 
            };
            Console.WriteLine(car3);
            car3.MakeHonkNoise("tweet tweet");
            car3.MakeEngineNoise("rumble rumble");
            Console.WriteLine(car3);
            carLot.Cars.Add(car3);

            int count = 0;
            Console.WriteLine("\nCars on Lot:");
            foreach(Car car in carLot.Cars) 
            {
                count++;
                Console.WriteLine($"\n#{count}:\nYear: {car.Year}\nMake: {car.Make}\nModel: {car.Model}");
            }
                //Set the properties for each of the cars
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
