using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Person: IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Default Constructor
        public Person() { }

        //Parameterized Constructor

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name} \t Age: {Age}");
        }

        //CompareTo method from IComparable<> Interface
        public int CompareTo(Person person)
        {
            if (this.Age > person.Age)
            {
                return 1;
            }
            else if (this.Age < person.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            //List object
            List<Person> list = new List<Person>();
            var p1 = new Person("Sayali Bharambe", 22);
            var p2 = new Person("Priti Patil", 20);
            var p3 = new Person("Aditi Rai", 23);

            //Adding in the list
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            Console.WriteLine("\n----- Sorting According to Age -----");
            Console.WriteLine("\n--------- Before Sorting ---------");
            foreach (Person p in list)
            {
                p.PrintDetails();
            }

            list.Sort();

            Console.WriteLine("\n--------- After Sorting ---------");
            foreach (Person p in list)
            {
                p.PrintDetails();
            }

            Console.ReadLine(); 
        }

    }
}
