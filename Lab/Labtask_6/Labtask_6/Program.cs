using System;
namespace Class_Work_1
{
    public class Food
    {
        public string name;
        public string[] ingredients;
        public double price;
        public float calories;

        public Food() // Empty Constructor
        {
            name = string.Empty;
            price = 0.0;
            calories = 0.0f;
            ingredients = new string[0];
        }

        public Food(string name, string[] ingredients, double price, float calories)  // Perameterized Constructor
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
            this.calories = calories;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setIngredients(string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setCalories(float calories)
        {
            this.calories = calories;
        }

        public string getName()
        {
            return this.name;
        }

        public string[] getIngredients()
        {
            return this.ingredients;
        }

        public double getPrice()
        {
            return this.price;
        }

        public float getCalories()
        {
            return this.calories;
        }

        public void removeIngredient(string ingredient)
        {
            int index = Array.IndexOf(ingredients, ingredient);
            if (index >= 0)
            {
                string[] newIngredients = new string[ingredients.Length - 1];
                int newIndex = 0;
                for (int i = 0; i < ingredients.Length; i++)
                {
                    if (i != index)
                    {
                        newIngredients[newIndex++] = ingredients[i];
                    }
                }
                ingredients = newIngredients;
            }
        }

        public void addIngredient(string ingredient)
        {
            int newLength = ingredients.Length + 1;
            string[] newIngredients = new string[newLength];
            for (int i = 0; i < ingredients.Length; i++)
            {
                newIngredients[i] = ingredients[i];
            }
            newIngredients[newLength - 1] = ingredient;
            ingredients = newIngredients;
        }

        public virtual void showDetails()
        {
            Console.WriteLine("\tName: " + getName());
            Console.WriteLine("\tIngredients: " + string.Join(", ", getIngredients()));
            Console.WriteLine("\tPrice: $" + getPrice());
            Console.WriteLine("\tCalories: " + getCalories());
        }
    }

    public class Drinks : Food
    {
        public string type;
        public int sizeInLitter;

        public Drinks()  // Empty Constructor
        {
            type = string.Empty;
            sizeInLitter = 0;
        }

        public Drinks(string name, string[] ingredients, double price, float calories, string type, int sizeInLitter)  // Perameterized Constructor
        : base(name, ingredients, price, calories)
        {
            this.type = type;
            this.sizeInLitter = sizeInLitter;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setSize(int sizeInLitter)
        {
            this.sizeInLitter = sizeInLitter;
        }

        public int getSize()
        {
            return this.sizeInLitter;
        }

        public string getType()
        {
            return this.type;
        }

        public override void showDetails()
        {
            base.showDetails();
            Console.WriteLine("\tType: " + getType());
            Console.WriteLine("\tSize (in L): " + getSize());
        }
    }

    public class Burger : Food
    {
        public int numberOfPatty;

        public Burger()  // Empty Constructor
        {
            numberOfPatty = 0;
        }

        public Burger(string name, string[] ingredients, double price, float calories, int numberOfPatty) : base(name, ingredients, price, calories)  // Perameterized Constructor
        {
            this.numberOfPatty = numberOfPatty;
        }

        public void setNumberOfPatty(int numberOfPatty)
        {
            this.numberOfPatty = numberOfPatty;
        }

        public int getNumberOfPatty()
        {
            return this.numberOfPatty;
        }

        public override void showDetails()
        {
            base.showDetails();
            Console.WriteLine("\tNumber of Patty For Each Burger: " + getNumberOfPatty());
        }
    }

    public class Pizza : Food
    {
        public int sizeInInches;

        public Pizza()  // Empty Constructor
        {
            sizeInInches = 0;
        }

        public Pizza(string name, string[] ingredients, double price, float calories, int sizeInInches) : base(name, ingredients, price, calories)  // Perameterized Constructor
        {
            this.sizeInInches = sizeInInches;
        }

        public void setSize(int sizeInInches)
        {
            this.sizeInInches = sizeInInches;
        }

        public int getSize()
        {
            return this.sizeInInches;
        }

        public override void showDetails()
        {
            base.showDetails();
            Console.WriteLine("\tSize In Inches For Each Pizza: " + sizeInInches);
        }
    }

    //Resturent Class
    public class Resturent
    {
        public string resturentName;
        Drinks[] drink = new Drinks[100];
        Burger[] burger = new Burger[100];
        Pizza[] pizzas = new Pizza[100];

        public Resturent()
        { }

        public Resturent(String resturentName)
        {
            this.resturentName = resturentName;
        }

        public void setResturentName(string resturentName)
        {
            this.resturentName = resturentName;
        }

        public string getResturentName()
        {
            return resturentName;
        }

        public void addDrink(Drinks d)
        {

        }

        public void removeDrink(Drinks d)
        {

        }

        public void showDrink()
        {

        }

        /*public double calculateBill()
        {

        }*/

        public void addBurger(Burger b)
        {

        }

        public void removeDrink(Burger b)
        {

        }

        public void showBurger()
        {

        }

        /*public double calculateBill()
        {

        }*/

        public void addPizza(Pizza p)
        {

        }

        public void removePizza(Pizza p)
        {

        }

        public void showPizza()
        {

        }

        /*public double calculateBill()
        {

        }*/

    }

    // Driver Class
    public class Program
    {
        public static void Main (string [] args)
        {
            string[] ingred = new string[5] { "water", "sugar", "caffeine", "phosphoric acid", "caramel color" };
            Drinks drink1 = new Drinks("Coca-Cola", ingred, 1.99, 140, "soda", 2);
            Drinks drink2 = new Drinks("Orange Juice", new string[] { "orange juice concentrate", "water", "sugar" }, 2.49, 120, "juice", 3);

            // demonstrate all the methods and constructors

            // For Drinks
            Console.WriteLine("Drink 1 Information: ");
            drink1.showDetails();

            Console.WriteLine("\nDrink 2 Information: ");
            drink2.showDetails();

            drink1.removeIngredient("caffeine");
            drink1.addIngredient("Mossarella");

            Console.WriteLine("\nDrink 1 Updated Information: ");
            drink1.showDetails();
            Console.WriteLine(); Console.WriteLine();

            // For Burgers
            Burger burger1 = new Burger("Kalu Burger", new string[] { "wheat", "vegetablel oil", "Beef", "cheese" }, 400, 400, 2);
            Burger burger2 = new Burger("Naga Burger", new string[] { "wheat", "vegetablel oil", "Beef", "cheese", "Chili" }, 400, 400, 2);

            Console.WriteLine("\nBurger 1 Information: ");
            burger1.showDetails();

            Console.WriteLine("\nBurger 2 Information: ");
            burger2.showDetails();

            burger1.removeIngredient("Beef");
            burger1.addIngredient("Peper");

            Console.WriteLine("\nBurger 1 Updated Information: ");
            burger1.showDetails();
            Console.WriteLine(); Console.WriteLine();

            // Pizza Details
            Pizza pizza1 = new Pizza("Greek Pizza", new string[] { "feta", "roasted red peppers", "artichokes", "olive" }, 400, 100, 12);
            Pizza pizza2 = new Pizza("California Pizza", new string[] { "chicken", "peanut sauce", "artichoke hearts", "goat cheese" }, 400, 100, 12);

            Console.WriteLine("\nPizza 1 Information: ");
            pizza1.showDetails();

            Console.WriteLine("\nPizza 2 Information: ");
            pizza2.showDetails();

            pizza1.removeIngredient("feta");
            pizza1.addIngredient("Cola");

            Console.WriteLine("\nPizza 1 Updated Information: ");
            pizza1.showDetails();

            Console.ReadKey();

        }
    }
}
