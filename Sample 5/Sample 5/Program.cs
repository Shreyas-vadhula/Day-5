using System;

namespace Sample_5
{
    public class Person
    {
        public String Name { get; set; }
        public Person(String _name)
        {
            Name = _name;
        }
        public override string ToString()
        {
            return "Hi I am "+Name;
        }
        ~Person()
        {
            Name=String.Empty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;            
            Person[] persons = new Person[n];
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("Enter a name");
                String name = Console.ReadLine();
                Person person = new Person(name);
                persons[i] = person;              
            }        
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}
