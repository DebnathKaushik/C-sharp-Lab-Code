using System;
namespace Lab_4_4
{
    public class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(10);

            Console.WriteLine($"Circle 1 - Radius: {circle1.radius} - Area: {circle1.CalculateArea()} - Circumference: {circle1.CalculateCircumference()}");
            Console.WriteLine($"Circle 2 - Radius: {circle2.radius} - Area: {circle2.CalculateArea()} - Circumference: {circle2.CalculateCircumference()}");

            Circle[] circles = { new Circle(1), new Circle(2), new Circle(3), new Circle(4), new Circle(5) };
            foreach (Circle circle in circles)
            {
                Console.WriteLine($"Radius: {circle.radius} - Area: {circle.CalculateArea()} - Circumference: {circle.CalculateCircumference()}");
            }

            Console.ReadKey();
        }
    }
}

