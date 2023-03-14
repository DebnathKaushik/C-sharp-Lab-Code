
using System;

namespace Lab_3;

public class Food
{
    String name;
    String[] ingredients;
    double price;
    float calories;

    public Food() { }

    public Food(string name, string[] ingredients, double price, float calories)
    {
        this.name = name;
        this.ingredients = ingredients;
        this.price = price;
        this.calories = calories;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public void setPrice(float price)
    {
        this.price = price;
    }

    public void setIngredients(String[] ingredients)
    {
        this.ingredients = ingredients.ToArray();
    }

    public void setCalories(float calories)
    {
        this.calories = calories;
    }
    public String getName()
    {
        return name;
    }

    public double getPrice()
    {
        return price;
    }

    public float getCalories()
    {
        return calories;
    }

    public string[] getIngredients()
    {
        return ingredients;
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
        Console.WriteLine("Add New Ingredient : "+ingredient);
    }

    public void showDetails()
    {
        Console.WriteLine("Name of food :" + getName());
        Console.WriteLine("Ingredients: " + string.Join(", ", getIngredients()));
        Console.WriteLine("Price: " + getPrice());
        Console.WriteLine("Calories: " + getCalories());
       
    }
}

public class Start
{
static void Main(string[] args)
{
    string[] ingredients = { "tomato","onion","paper" };
        Food food1 = new Food("Pakora, Chaat, vada Pao", ingredients, 799, 1069f);
        Console.WriteLine("Food 1 Details:");
        food1.showDetails();
        food1.addIngredient("salt");

        Console.WriteLine();

    string[] ingredients2 = { "water", "salt", "flour" };
    Food food2 = new Food("Chicken Makhani and Naan", ingredients2, 450, 300f);
    Console.WriteLine("Food 2 Details:");
    food2.showDetails();

    Console.ReadKey();
}
}
