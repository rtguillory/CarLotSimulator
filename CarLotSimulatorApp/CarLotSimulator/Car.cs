using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model,bool isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isdriveable;
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise) { EngineNoise = engineNoise; }

        public void MakeHonkNoise(string honkNoise) { HonkNoise = honkNoise;}

        public override string ToString()
        {
            return $"\nYear: {this.Year}\nMake: {this.Make}\nModel: {this.Model}\nDriveable: {this.IsDriveable}\nEngine Noise: {this.EngineNoise}\nHonkNoise: {this.HonkNoise} ";

        }

    }
}
