using System;
namespace Final_Labtask_4
{
    public interface ICalculater
    {
        public int sum(int x,int y);
        public int sub(int x,int y);
        public int mul(int x,int y);
        public int div(int x,int y);
    }

    public interface ScienticCalculater
    {
        public int XtoY(int x,int y);

    }

    public class Calculator : ICalculater, ScienticCalculater
    {
        public int sum(int x, int y)
        {
            return x+y;
        }
        public int sub(int x, int y) 
        {
            return x-y;
        }

        public int mul(int x, int y)
        {
            return x*y;
        }

        public int div(int x, int y)
        {
            if(y==0)
            {
                throw new DivideByZeroException("Can't Divide By Zero");
            }
            return x/y;
        }


        public int XtoY(int x,int y)
        {
            return (int)Math.Pow(2, 3);
        }



    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator obj1 = new Calculator();
            Console.WriteLine("Sumation of two number (5,6):" + obj1.sum(5, 6));
            Console.WriteLine("Subtraction of two number (6,5):" + obj1.sub(6, 5));
            Console.WriteLine("Multiplication of two number (5,6):" + obj1.mul(5, 6));
            Console.WriteLine("Division of two number (5,5):" + obj1.div(5, 5));
            Console.WriteLine("Square of two number (2,2):" + obj1.XtoY(2, 2));
        }

    }
}
    