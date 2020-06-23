using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class CompareByBirthday : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if (e1.GetBirthday() > e2.GetBirthday())
                return 1;
            else if (e1.GetBirthday() < e2.GetBirthday())
                return -1;
            else
                return 0;
        }
    }
}
