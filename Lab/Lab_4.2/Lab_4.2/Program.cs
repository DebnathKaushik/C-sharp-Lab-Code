using System;

namespace Lab_4_2
{
    class Employee
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


        public void display()
        {
            Console.WriteLine("name is :" + name);
            Console.WriteLine("age is :" + age);
            Console.WriteLine("Salary is :" + salary);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Employee obj1 = new Employee("kaushik", 20, 50000.0);
            obj1.display();

            Employee obj2 = new Employee("Sokal", 20, 70000.0);
            obj2.display();


        }




    }



}

    





