using System;
namespace Interface
{
    public interface ISound
    {
        public void Makesound();
    }

    public interface IFeed
    {
        public void Feed();
    }

    public class cat : ISound, IFeed
    {
        public void Makesound()
        {
            Console.WriteLine("Cat make sound");
        }

        public void Feed()
        {
            Console.WriteLine("Cat will eat");
        }
    }

    public class Dog: ISound,IFeed

    {
        public void Feed() 
        {
            Console.WriteLine("Dog will eat");
        }
        public void Makesound()
        {
            Console.WriteLine("Dog make sound");
        }
    }
    class Animal
    {
        public static void Main(string[] args) 
        {
            ISound [] arr = new ISound[2];
            arr[0] = new Dog();
            arr[1] = new cat();

            foreach(ISound i in arr) 
            {
                i.Makesound();
            }

            IFeed[] arr2 = new IFeed[2];
            arr2[0] = new Dog();
            arr2[1] = new cat();

            foreach (IFeed i in arr2)
            {
                i.Feed();
            }


        }
    }
}
