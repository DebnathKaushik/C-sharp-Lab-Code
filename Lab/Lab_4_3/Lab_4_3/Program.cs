using System;

namespace Lab_4_3
{
    public class Employee
    {
        public string name;
        public int age;
        public double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        { 
            Employee[] arr = new Employee[10];                         // class type array  

            for (int i = 0; i < arr.Length; i++)                        // input in array

            {
                Console.WriteLine("Enter details for employee {0}:", i + 1);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                arr[i] = new Employee(name, age, salary);        //  object initialize in array with parameter
            }

            Employee highestSalaryEmployee = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].salary > highestSalaryEmployee.salary)
                {
                    highestSalaryEmployee = arr[i];
                }
            }

            Console.WriteLine("Details for employee with highest salary:");
            Console.WriteLine("Name: "+ highestSalaryEmployee.name);
            Console.WriteLine("Age: "+ highestSalaryEmployee.age);
            Console.WriteLine("Salary: " + highestSalaryEmployee.salary);

            Console.ReadKey();
        }
    }

}
