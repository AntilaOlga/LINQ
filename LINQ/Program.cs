using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = Initialization();

            LINQTesting(personsList);
            
            Console.ReadLine();
        }

        static List<Person> Initialization()
        {
            return new List<Person>
            {
                new Person("Иван", 31, "Male", 400),
                new Person("Женя", 24, "Male", 21000),
                new Person("Даша", 22, "Female", 570),
                new Person("Леша", 25, "Male", 14758),
                new Person("Соня", 27, "Female", 4792),
            };

        }

        static void LINQTesting(List<Person> personsList)
        {
            //1.1
            var item = personsList.OrderByDescending(x => x.Age).First();
            Console.WriteLine($"Самый старший: {item.Name}");

            //1.2
            item = personsList.OrderByDescending(x => x.Balance).First();
            Console.WriteLine($"Самый богатый: {item.Name}");

            //2.1
            var count = personsList.Where(x => x.Balance > 4000).Count();
            Console.WriteLine($"Количество людей с балансом больше 4000: {count}");

            //3.1
            var items = personsList.OrderBy(x => x.Age).ToList();
            Person.DisplayList("Сортировка по возрасту:", items);

            //3.2
            items = personsList.OrderBy(x => x.Sex).ToList();
            Person.DisplayList("Сортировка по полу:", items);

            //3.3
            items = personsList.OrderBy(x => x.Sex).ToList();
            Person.DisplayList("Сортировка по балансу:", items);

            //1.3
            personsList.Add(new Person("Андрей", 30, "Male", 21000));
            item = personsList.OrderByDescending(x => x.Age)
                              .OrderByDescending(x => x.Balance)
                              .First();
            Console.WriteLine($"Из самых богатых самый старший: {item.Name}");

        }
    }
}
