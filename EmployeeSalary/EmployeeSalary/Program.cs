using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            //U petlji kreiramo novu osobu. Problem: Resiti parametre unutar konstruktora, lines oznacava koliko puta prolazimo kroz petlju!!!
            for (int i = 0; i < lines; i++)
            {
                var person = new Person("Sam", "Smith", 18, 350.5);
                persons.Add(person);
            }

            //Upisati bonus u % za povecanje plate
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadLine();
        }
    }
}
