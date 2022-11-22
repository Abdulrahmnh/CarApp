using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Car myCar = new Car("Ford", "Black", 2019);
            myCar.Move();
            myCar.Accelerate(120);
            Car.AddCar();
            Car.AddCar();
            int carsCount = Car.AddCar();
            Console.WriteLine("Number of objects from class Car = " + carsCount);
            Console.ReadKey();
        }
    }

    // Define class, (Make sure to name it in an UpperCamelCase way) 
    class Car
    {
        private String model;
        public String Color { get; set; } // shorter way
        public int ModelYear { get; set; }
        static int Count = 0;

        // Solution of the project
        public void ChangeOil(int liters)
        {
            Console.WriteLine("Oil changed! " + liters + " of oil were consumed!");

        }


        public static int AddCar()
        {
            Count++;
            return Count;
        }

        // short way
        public String Model
        {
            get
            {
                return "(" + model + ")";
            }
            set
            {
                model = value.ToUpper();
            }
        }

        public void print()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Model Year: " + ModelYear);
        }

        public Car(String Model, String Color, int ModelYear)
        {
            this.Model = Model;
            this.Color = Color;
            this.ModelYear = ModelYear;
            print();
        }

        public void Move()
        {
            Console.WriteLine("Car is moving!");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("Car is moving ar speed " + speed + "kph");
        }
    }
}
