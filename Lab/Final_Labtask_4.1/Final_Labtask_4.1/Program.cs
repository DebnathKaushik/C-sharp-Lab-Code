using System;
namespace Final_Labtask_4 
{
    // Define the interface for basic banking operations
    public interface BasicBankingInterface
    {
        bool deposit(int amount);
        bool withdraw(int amount);
    }

    // Define an abstract class for bank account
    public abstract class BankAccount : BasicBankingInterface
    {
        // Fields for account holder name, balance and account type
        protected string name;
        protected int balance;
        protected string type;

        // Constructor to initialize the fields
        public BankAccount(string name, int balance, string type)
        {
            this.name = name;
            this.balance = balance;
            this.type = type;
        }

        // Abstract methods to be implemented by subclasses
        public abstract bool deposit(int amount);
        public abstract bool withdraw(int amount);

        // Method to change the account type
        public void changeType(string newType)
        {
            this.type = newType;
            Console.WriteLine("Account type changed to {0}", newType);
        }

        // Method to display the account details
        public void display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Type: {0}", type);
        }
    }

    // Define a subclass for current account
    public class CurrentAccount : BankAccount
    {
        // Constructor to call the base class constructor
        public CurrentAccount(string name, int balance) : base(name, balance, "Current")
        {

        }

        // Override the deposit method to add the amount to the balance
        public override bool deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited {0} to current account", amount);
            return true;
        }

        // Override the withdraw method to subtract the amount from the balance if possible
        public override bool withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrew {0} from current account", amount);
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds in current account");
                return false;
            }

        }
    }

    // Define a subclass for saving account
    public class SavingAccount : BankAccount
    {
        // Constructor to call the base class constructor
        public SavingAccount(string name, int balance) : base(name, balance, "Saving")
        {

        }

        // Override the deposit method to add the amount to the balance
        public override bool deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited {0} to saving account", amount);
            return true;
        }

        // Override the withdraw method to subtract the amount from the balance if possible and within 80% limit
        public override bool withdraw(int amount)
        {
            if (amount <= 0.8 * balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrew {0} from saving account", amount);
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawal limit exceeded in saving account");
                return false;
            }

        }
    }

    // Define a subclass for overdraft account
    public class OverdraftAccount : BankAccount
    {
        // Field for overdraft limit
        private int limit;

        // Constructor to call the base class constructor and initialize the limit
        public OverdraftAccount(string name, int balance, int limit) : base(name, balance, "Overdraft")
        {
            this.limit = limit;

        }

        // Override the deposit method to add the amount to the balance
        public override bool deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited {0} to overdraft account", amount);
            return true;
        }

        // Override the withdraw method to subtract the amount from the balance if possible and within overdraft limit
        public override bool withdraw(int amount)
        {
            if (amount <= balance + limit)
            {
                balance -= amount;
                Console.WriteLine("Withdrew {0} from overdraft account", amount);
                return true;
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded in overdraft account");
                return false;
            }

        }
    }

    public class Start2
    {
        // Define the main method
        public static void Main(string[] args)
        {
            // Create some bank accounts of different types
            BankAccount obj1 = new CurrentAccount("Alice", 1000);
            BankAccount obj2 = new SavingAccount("Bob", 2000);
            BankAccount obj3 = new OverdraftAccount("Charlie", 500, 300);

            // Display the account details
            Console.WriteLine("Initial account details:");
            obj1.display();
            obj2.display();
            obj3.display();

            // Perform some banking operations
            Console.WriteLine("Performing some banking operations:");
            obj1.deposit(500);
            obj2.withdraw(1000);
            obj3.withdraw(800);

            // Display the updated account details
            Console.WriteLine("Updated account details:");
            obj1.display();
            obj2.display();
            obj3.display();

            // Change the account type of a1 to saving
            Console.WriteLine("Changing the account type of a1 to saving:");
            obj1.changeType("Saving");

            // Display the changed account details
            Console.WriteLine("Changed account details:");
            obj1.display();
        }
    }
}





