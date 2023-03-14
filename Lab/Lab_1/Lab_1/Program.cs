using System;

namespace Lab_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("what is your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+" "+name);

            Console.WriteLine("Enter your id :");
            Double id = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("your id is :" + id);*/


            /* Console.WriteLine("Enter Number");
             int day = Convert.ToInt32( Console.ReadLine());

             switch(day)
             {
                 case 1:
                     Console.WriteLine("Today is Sunday");
                     break;
                 case 2:
                     Console.WriteLine("Today is Monday");
                     break;
                 case 3:
                     Console.WriteLine("Today is Tuseday");
                     break;
                 case 4:
                     Console.WriteLine("Today is Wednesday");
                     break;
                 default:
                     Console.WriteLine("Invalid Command");
                     break;

             }*/


            /*Console.WriteLine("Enter first Number :");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Sign :");
            string Sign = Console.ReadLine();

           switch(Sign)
            {
                case "+":
                    Console.WriteLine($"Result :  { First + Second}");
                    break;
                case "-":
                    Console.WriteLine( $"Result: { First - Second}");
                    break;
                case "*":
                    Console.WriteLine(  First * Second);
                    break;
                case "/":
                    Console.WriteLine(  First / Second);
                    break;



            }*/


            // array 

            int[] arr1= new int [5];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;

            for(int i = 0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }

             Console.WriteLine("Second Array :");

            int[] arr2=new int[] {10,20,30,40,50,60,70};      // This is unlimited array

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("Third Array :");

            int[,] arr3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6} };

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1) ; j++)
                {
                    Console.WriteLine(arr3[i,j]);
                }
            }



            Console.ReadKey();

        }
    }
}
