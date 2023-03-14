using System;

namespace Lab_5
{
    class Person
    {
        protected string name;
        protected string dob;

        public Person() { }

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getdob()
        {
            return this.dob;
        }

        public virtual void display() 
        {
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("Date of birth :" + dob);
        }


    }

    class Employee : Person
    {
        private string acc;
       

        public Employee() { }
        public Employee(string name,string dob,string acc) : base( name, dob)
        {
            this.acc = acc;
        }



        public void setAcc(string acc_id) 
        {
            this.acc = acc;
        }

        public string getacc_id()
        {
            return this.acc;
        }


       

        public override void display()
        {
            base.display();
            Console.WriteLine("Acc is :" + acc);

        }
    }


    class Customer : Person 
    {
        private int acc_id;
        private double amount;
        private string acc_type;

        public Customer() { }
        public Customer( string name, string dob, int acc_id,double amount,string acc_type) : base(name, dob)
        {
            this.acc_id= acc_id;
            this.acc_type= acc_type;
            this.amount = amount;
        }



        public void setAcc_id(int acc_id)
        {
            this.acc_id = acc_id;
        }

        public void set_amount(double amount)
        {
            this.amount = amount;
        }

        public void set_acc_type(string acc_type)
        {
            this.acc_type = acc_type;
        }


        public int getAcc_id()
        {
            return this.acc_id;
        }

        public double get_amount()
        {
            return this.amount;
        }

        public string get_acc_type()
        {
            return this.acc_type;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Acc_id is :" + acc_id);
            Console.WriteLine("Amount is :" + amount);
            Console.WriteLine("Acc_type is :" + acc_type);
        }
    }


    public class Program
    {
        public static void Main(string [] args)
        {
            

            Employee obj2 = new Employee("Sokal", "23-07-2002","20-3040");
            obj2.display();
            Console.WriteLine();


            Customer obj3 = new Customer("kaushik Debnath", "20-11-2000", 102030,6000.00,"savings");
            obj3.display();




        }

    }

       
}

