using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get { return _firstName; }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be less than 3 chars");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 5 chars.");
                }

                _lastName = value;
            }
        }

        public int Age
        {
            get { return _age; }

            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Person under 18 years, cannot work.");
                }

                _age = value;
            }
        }

        public double Salary
        {
            get { return _salary; }

            set
            {
                if (value < 350.0)
                {
                    throw new ArgumentException("Salary cannot be less than 350$");
                }

                _salary = value;
            }
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} get {_salary}$";
        }

        public void IncreaseSalary(double percent)
        {
            if (_age > 30)
            {
                _salary += _salary * percent / 100;
            }
            else
            {
                _salary += _salary * percent / 200;
            }
        }
    }
}
