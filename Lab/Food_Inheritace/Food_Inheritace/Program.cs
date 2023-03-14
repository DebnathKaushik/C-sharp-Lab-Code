using System;

namespace Food_Inheritace
{


// Food class
class Food
{
    private string name;
    private string[] ingredients;
    private double price;
    private float calories;

    public Food() { }

    public Food(string name, string[] ingredients, double price, float calories)
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
        return name;
    }

    public string[] getIngredients()
    {
        return ingredients;
    }

    public double getPrice()
    {
        return price;
    }

    public float getCalories()
    {
        return calories;
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
            int length = ingredients.Length;
            Array.Resize(ref ingredients, length + 1);
            ingredients[length] = ingredient;
            Console.WriteLine("Add New Ingredient : " + ingredient);
        }


        public virtual void showDetails()
        {
            Console.WriteLine("Name of food :" + getName());
            Console.WriteLine("Ingredients: " + string.Join(", ", getIngredients()));
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Calories: " + getCalories());

        }


 }

// Drinks class
class Drinks : Food
{
    private string type;
    private int sizeInLitter;

    public Drinks() { }

    public Drinks(string name, string[] ingredients, double price, float calories, string type, int sizeInLitter)
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

    public string getType()
    {
        return type;
    }

    public int getSize()
    {
        return sizeInLitter;
    }
}

// Burger class
class Burger : Food
{
    private int numberOfPatty;

    public Burger() { }

    public Burger(string name, string[] ingredients, double price, float calories, int numberOfPatty)
        : base(name, ingredients, price, calories)
    {
        this.numberOfPatty = numberOfPatty;
    }

    public void setNumberOfPatty(int numberOfPatty)
    {
        this.numberOfPatty = numberOfPatty;
    }

    public int getNumberOfPatty()
    {
        return numberOfPatty;
    }

    public override void  showDetails()
    {
        base.showDetails();
        Console.WriteLine("Number of patty: "+numberOfPatty);
    }
}

// Pizza class
class Pizza : Food
{
    private int sizeInInches;

    public Pizza() { }

    public Pizza(string name, string[] ingredients, double price, float calories, int sizeInInches)
        : base(name, ingredients, price, calories)
    {
        this.sizeInInches = sizeInInches;
    }

    public void setSize(int sizeInInches)
    {
        this.sizeInInches = sizeInInches;
    }

    public int getSize()
    {
        return sizeInInches;
    }
        public void showdetails()
        {
            base.showDetails();
            Console.WriteLine("SizeInInches are : ");
        }
     
}

    // Start class
    class Start
    {
        public static void Main(string[] args)
        {
            string[] ingredients =new string[]{ "water", "soda", "sugar","laktic Acid" };
            Drinks obj1 = new Drinks("Fizz Up",ingredients,30,360,"soft",500);
            Drinks obj2 = new Drinks("MoJo", new string[] { "water","sugar","soda" }, 40, 260, "soft", 400);

            Burger obj3 = new Burger("Naga Burger", new string[] { "wheat","water", "mustard oil" }, 300, 560, 1);
            obj3.showDetails();
            Burger obj4 = new Burger("KFC Burger", new string[] { "water", "wheat", "mustard", "fat cheese" }, 350, 760,1);
            obj4.showDetails();


            Pizza obj5 = new Pizza("Neapolitan Pizza", new string[] { "wheat", "water", "mustard", "mushroom","curst" }, 500, 560, 12);
            obj5.showDetails();
            Pizza obj6 = new Pizza("Saucy Pizza", new string[] { "water", "wheat", "cheese", "fat cheese", "Black Olives" }, 450, 760, 10);
            obj6.showDetails();




        }
    }
}
