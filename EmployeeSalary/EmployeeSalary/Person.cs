using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Last name cannot be less than 5 symbols.");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("People under 18 years, cannot work.");
                }

                this.age = value;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 350)
                {
                    throw new ArgumentException("Salary cannot be less than 350$");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} have {this.salary} monthly";
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }
    }
}
