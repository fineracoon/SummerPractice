using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class CompareBySalary : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if (e1.GetSalary() > e2.GetSalary())
                return 1;
            else if (e1.GetSalary() < e2.GetSalary())
                return -1;
            else
                return 0;
        }
    }
}
