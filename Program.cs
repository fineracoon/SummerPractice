using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void SortByBirthday(ref List<Employee> employees)
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].GetBirthday().CompareTo(employees[j].GetBirthday()) > 0)
                    {
                        Employee buffer = employees[i];
                        employees[i] = employees[j];
                        employees[j] = buffer;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee(24847, "John Smith", new DateTimeOffset(new DateTime(1985, 11, 25)), 350.50);
            Employee e2 = new Employee();
            e2.SetId(14598);
            e2.SetName("Adam Sendler");
            e2.SetBirthday(new DateTimeOffset(new DateTime(1990, 9, 12)));
            e2.SetSalary(280.70);
            Employee e3 = new Employee(e1);
            e3.SetId(35478);

            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);

            Console.WriteLine("Before sorting");
            foreach (Employee e in employees)
            {
                e.toString();
            }

            SortByBirthday(ref employees);

            Console.WriteLine("After sorting");
            foreach (Employee e in employees)
            {
                e.toString();
            }

            Console.ReadKey();
        }
    }
}
