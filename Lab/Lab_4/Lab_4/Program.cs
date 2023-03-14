using System;

namespace Lab_4
{
    class Student
    {
        public string name;
        public int age;
        public int marks1;
        public int marks2;
        public int marks3;

        public Student(string name, int age, int marks1,int marks2,int marks3)
        {
            this.name = name;
            this.age = age;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

         public double avarage ()
        {
            
            return (marks1+marks2+marks3)/3.0;
        }

        public void display()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("age :" + age);
            Console.WriteLine("marks are :"+marks1+" "+marks2+" "+marks3);
            Console.WriteLine("Avarage Marks :" + avarage());
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Student obj1 = new Student("Kaushik", 20, 90, 90, 90);
                obj1.avarage();
                obj1.display();

                Student obj2 = new Student("Sokal", 20, 91, 92, 93);
                obj2.avarage();
                obj2.display();


            }
        }




    }
}