using System;
namespace Lab_4_1
{
    class Student
    {
        public string name;
        public int age;
        public double mark1;
        public double mark2;
        public double mark3;

        public Student(string name, int age, double mark1, double mark2, double mark3)
        {
            this.name = name;
            this.age = age;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public double calculateAverage()
        {
            return (mark1 + mark2 + mark3) / 3.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Student [] students = new Student[2];        

            for (int i = 0; i < 5; i++)                                         // input in array 
            {
                Console.WriteLine("Enter details for student {0}:", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Mark 1: ");
                double mark1 = double.Parse(Console.ReadLine());
                Console.Write("Mark 2: ");
                double mark2 = double.Parse(Console.ReadLine());
                Console.Write("Mark 3: ");
                double mark3 = double.Parse(Console.ReadLine());

                students[i] = new Student(name, age, mark1, mark2, mark3);
            }*/


            Student obj1 = new Student("kaushik",20,72,78,96);
            Student obj2 = new Student("Sokal", 20, 70, 78, 96);
            Student obj3 = new Student("nondon", 20, 90,90, 90);


            double highestAverage = 0;
            string highestName = "";
            int highestAge = 0;

            for (int i = 0; i < 1 ; i++)
            {
                double average = obj1.calculateAverage();
                double average2 = obj2.calculateAverage();
                double average3 = obj3.calculateAverage();

                Console.WriteLine("Details for student :", i + 1);
                Console.WriteLine("Name: " + obj1.name);
                Console.WriteLine("Age: " + obj1.age);
                Console.WriteLine("Average marks: " + average);

                Console.WriteLine("Details for student :", i + 1);
                Console.WriteLine("Name: " + obj2.name);
                Console.WriteLine("Age: " + obj2.age);
                Console.WriteLine("Average marks: " + average2);

                Console.WriteLine("Details for student :", i + 1);
                Console.WriteLine("Name: " + obj3.name);
                Console.WriteLine("Age: " + obj3.age);
                Console.WriteLine("Average marks: " + average3);


                if (average > average2 && average >average3) 
                {

                    if (average > highestAverage)
                    {
                        highestAverage = average;
                        highestName = obj1.name;
                        highestAge = obj1.age;
                    }
                }

                else if(average3 > average && average3 > average2)
                {
                    if (average3 > highestAverage)
                    {
                        highestAverage = average3;
                        highestName = obj3.name;
                        highestAge = obj3.age;
                    }


                }
               
                



                else
                {
                    if (average2 > highestAverage)
                    {
                        highestAverage = average2;
                        highestName = obj2.name;
                        highestAge = obj2.age;
                    }

                }

                

                    

                    
                   
                       
                   
                

                

                


            }

            /*double highestAverage = 0;
            string highestName = "";
            int highestAge = 0;

            for (int i = 0; i < 5; i++)
            {
                double average = students[i].calculateAverage();

                Console.WriteLine("Details for student :", i + 1);
                Console.WriteLine("Name: "+ students[i].name);
                Console.WriteLine("Age: "+students[i].age);
                Console.WriteLine("Average marks: "+ average);

                if (average > highestAverage)
                {
                    highestAverage = average;
                    highestName = students[i].name;
                    highestAge = students[i].age;
                }
            }*/

            Console.WriteLine("The student with the highest average marks is:");
            Console.WriteLine("Name: {0}", highestName);
            Console.WriteLine("Age: {0}", highestAge);
            Console.WriteLine("Average marks: {0}", highestAverage);
        }
    }
}
