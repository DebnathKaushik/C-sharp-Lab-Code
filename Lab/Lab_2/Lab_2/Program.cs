

                                                   // problem 1 


using System;
class Program
{
    public static void Main(string[] args)
    {
        int[][] students = new int[5][];

        for (int i = 0; i < 5; i++)
        {
            students[i] = new int[3];
            Console.WriteLine("Enter the details of student " + (i + 1));
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Marks in subject 1: ");
            students[i][0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks in subject 2: ");
            students[i][1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks in subject 3: ");
            students[i][2] = Convert.ToInt32(Console.ReadLine());
        }

        string bestStudent = "";
        double highestAverage = 0;

        for (int i = 0; i < 5; i++)
        {
            double average = (students[i][0] + students[i][1] + students[i][2]) / 3.0;
            Console.WriteLine("Average marks of student " + (i + 1) + ": " + average);
            if (average > highestAverage)
            {
                highestAverage = average;
                bestStudent = "Student " + (i + 1);
            }
        }

        Console.WriteLine("Best performing student: " + bestStudent);
        Console.ReadKey();
    }
}




                                             // problem 2

/*using System;

class Program
{
    public static void Main(string[] args)
    {
        string[][] employees = new string[10][];

        for (int i = 0; i < 10; i++)
        {
            employees[i] = new string[3];
            Console.WriteLine("Enter the details of employee " + (i + 1));
            Console.Write("Name: ");
            employees[i][0] = Console.ReadLine();
            Console.Write("Age: ");
            employees[i][1] = Console.ReadLine();
            Console.Write("Salary: ");
            employees[i][2] = Console.ReadLine();
        }

        double averageSalary = 0;
        string highestPaidEmployee = "";
        int highestSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            averageSalary += Convert.ToInt32(employees[i][2]);
            if (Convert.ToInt32(employees[i][2]) > highestSalary)
            {
                highestSalary = Convert.ToInt32(employees[i][2]);
                highestPaidEmployee = employees[i][0];
            }
        }

        averageSalary /= 10;
        Console.WriteLine("Average salary: " + averageSalary);
        Console.WriteLine("Highest paid employee: " + highestPaidEmployee);
    }
}
*/





// problem 3



/*using System;

 class Program
{
     public static void Main(string[] args)
     {
         int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

         int[] rowSums = new int[3];
         int[] colSums = new int[3];

         for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 rowSums[i] += arr[i, j];
                 colSums[j] += arr[i, j];
             }
         }

         Console.WriteLine("Row sums: " + string.Join(", ", rowSums));
         Console.WriteLine("Column sums: " + string.Join(", ", colSums));
     }
}*/