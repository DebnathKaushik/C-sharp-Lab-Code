using System;
namespace Lab_task_9
{
    class Program
    {
        public static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Enter 1st number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number :");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            } 
            catch(FormatException ex)
            {
                Console.WriteLine("Error !");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error ");
            }
            finally
            {
                Console.WriteLine("Code is Run");
            }
        }
    }
}