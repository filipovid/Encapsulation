using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Number of persons: ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();
                var person = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));

                persons.Add(person);
            }

            Console.WriteLine("Bonus in %: ");
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadLine();
        }
    }
}
