using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Group<T> where T : IAnimal
    {
        private string groupName;
        public List<T> arr;

        public Group()
        { }

        public Group(string name)
        {
            groupName = name;
            arr = new List<T>();
        }

        public string Name
        {
            get { return groupName; }
            set { groupName = value; }
        }
    }
}
