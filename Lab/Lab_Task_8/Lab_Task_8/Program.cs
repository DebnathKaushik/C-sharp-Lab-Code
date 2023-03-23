using System;
namespace Lab_Task_8
{
    public class Vehicle
    {
        public string brand;
        public string model;
        public string year;

        public Vehicle()
        {

        }

        public Vehicle(string brand, string model, string year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setYear(string year)
        {
            this.year = year;
        }
        public string getBrand()
        {
            return this.brand;
        }
        public string getModel()
        {
            return this.model;
        }
        public string getYear()
        {
            return this.year;
        }

        public virtual void StartEngine()
        {
            
            Console.WriteLine("brand: " + getBrand());
            Console.WriteLine("model: " + getModel());
            Console.WriteLine("year: " + getYear());
        }

    }

    public class Car : Vehicle
    {
        public int num_of_door;
        public Car() { }

        public Car(string brand, string model, string year, int num_of_door) : base(brand, model, year)
        {
            this.num_of_door = num_of_door;
        }

        public void setNum_of_Doors(int num_of_door)
        {
            this.num_of_door = num_of_door;
        }
        public int getDoors()
        {
            return this.num_of_door;
        }

        public override void StartEngine()
        {
            Console.WriteLine("The Engine of car is Started");
            base.StartEngine();
            Console.WriteLine("Number of door is :" +num_of_door);
        }

    }

    public class Motorcycle : Vehicle
    {
        public int Displacement;
        public Motorcycle() { }

        public Motorcycle(string brand, string model, string year, int Displacement) : base(brand, model, year)
        {
            this.Displacement = Displacement;
        }

        public void setDisplacement()
        {
            this.Displacement = Displacement;
        }

        public int getDisplacement()
        {
            return this.Displacement; 
        }
        public override void StartEngine()
        {
            Console.WriteLine("The Engine of Motorcycle is Started");
            base.StartEngine(); 
            Console.WriteLine("Displacement is :"+Displacement);
            
        }

    }

    public class Truck : Vehicle
    {
        public string maxWeight;
        public Truck() { }

        public Truck(string brand, string model, string year, string maxWeight) : base(brand, model, year)
        {
            this.maxWeight = maxWeight;
        }

        public void setMaxWeight()
        {
            this.maxWeight = maxWeight;
        }

        public string getMaxWeight()
        {
            return this.maxWeight;
        }

        public override void StartEngine()
        {
            Console.WriteLine("The engine of the Truck has started.");
            base.StartEngine();
            Console.WriteLine("MAxWeight is :" + maxWeight);
            
        }

    }

    public class classDemo
    {
        public static void Main(string[] args)
        {
            Car obj1 = new Car("Toyota", "Corolla", "2020", 4);
            obj1.StartEngine();
            Console.WriteLine();

            Motorcycle obj2 = new Motorcycle("BMW", "CGR1", "2022", 2);
            obj2.StartEngine();
            Console.WriteLine();

            Truck obj3 = new Truck("Mercedes", "Maybace", "2021", "1000 kg");
            obj3.StartEngine();

           



        }
    }

}