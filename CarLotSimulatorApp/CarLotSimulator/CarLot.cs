﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> Cars { get; set; }

        public static int numberOfCars;

        public CarLot() 
        {
            Cars = new List<Car>();
        }

        
    }

    
}
