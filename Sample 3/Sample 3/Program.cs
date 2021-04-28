using System;

namespace Sample_3
{
    public abstract class Animal
    {
        private String Name;
        public void SetName(String name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.Write("Dog is eating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Dogs name\n");
            String name = Console.ReadLine();
            Dog dog = new Dog();
            dog.SetName(name);
            dog.Eat();
            Console.ReadLine();
        }       
    }
}
