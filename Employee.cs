using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class Employee : IComparable<Employee>
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
            empID = id;
            empName = name;
            empBirthday = birthday;
            empSalary = salary;
        }

        public Employee(Employee employee)
        {
            this.empID = employee.empID;
            this.empName = employee.empName;
            this.empBirthday = employee.empBirthday;
            this.empSalary = employee.empSalary;
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

        
        public void toString()
        {
            Console.Write("ID: " + this.empID + "\r\n" +
                   "Name: " + this.empName + "\r\n" +
                   "Date of birthday: " + this.empBirthday.ToString("dd.MM.yyyy") + "\r\n" +
                   "Salary: " + empSalary + "\r\n");
        }

        public int CompareTo(Employee other)
        {
            if (this.GetBirthday().CompareTo(other.GetBirthday()) == 0)
                return this.GetSalary().CompareTo(other.GetSalary());
            return this.GetBirthday().CompareTo(other.GetBirthday());
        }
    }
}
