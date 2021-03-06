﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        //Properties
        public int YearModel { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }
        
        //This is a default constructor that creates an empty car
        public Car() { }

        //Constructor with properties (Has the same name as the class)
        public Car(int yearModel, string make)
        {
            this.YearModel = yearModel;
            this.Make = make;
            this.Speed = 0;
        }

        //Method for increasing speed
        public void Accelerate()
        {
            this.Speed += 5;
        }

        //Method for decreasing speed
        public void Brake()
        {
            this.Speed -= 5;
        }
    }
}
