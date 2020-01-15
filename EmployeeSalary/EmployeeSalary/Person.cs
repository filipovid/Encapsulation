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
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _salary = salary;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public int Age
        {
            get { return _age; }
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
