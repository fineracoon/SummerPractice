using System;
using System.Reflection;

namespace TypeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("TypeInfo.User", false, true);

            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Console.ReadKey();
        }
    }
}
