using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        public class Employee
        {
            private long empID;
            private string empName;
            private DateTimeOffset empBirthday;
            private double empSalary;

            public Employee()
            {
                empID = 0;
                empName = "";
                empBirthday = DateTimeOffset.MinValue;
                empSalary = 0.0;
            }

            public Employee(long id, string name, DateTimeOffset birthday, double salary)
            {

                empName = name;
                empBirthday = birthday;
                empSalary = salary;
            }

            public void SetId(long id)
            {
                empID = id;
            }

            public long GetId()
            {
                return empID;
            }

            public void SetName(string name)
            {
                empName = name;
            }

            public string GetName()
            {
                return empName;
            }

            public void SetBirthday(DateTimeOffset bd)
            {
                empBirthday = bd;
            }

            public DateTimeOffset GetBirthday()
            {
                return empBirthday;
            }

            public void SetSalary(double salary)
            {
                empSalary = salary;
            }

            public double GetSalary()
            {
                return empSalary;
            }

            public void SortByBirthday(ref List<Employee> employees)
            {
                for (int i = 0; i < employees.Count - 1; i++)
                {
                    for (int j = i + 1; j < employees.Count; j++)
                    {
                        if (employees[i].GetBirthday() < employees[j].GetBirthday())
                        {
                            Employee buffer = employees[i];
                            employees[i] = employees[j];
                            employees[j] = buffer;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
