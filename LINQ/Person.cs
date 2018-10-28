using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Balance { get; set; }

        public Person() { }
        public Person(string name, int age, string sex, int balance)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Balance = balance;
        }

        public static void DisplayList(string testMessage, List<Person> personList)
        {
            Console.WriteLine(testMessage);
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.Name} {person.Age} {person.Sex} {person.Balance}");
            }
        }
    }
}
