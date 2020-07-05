using System;
using System.Collections.Generic;
using System.Text;

namespace HumanTask
{
    class Girl : Human
    {
        private bool pregnancy;

        public Girl(string name, int age, Gender gender, bool p) : base(name, age, gender)
        {
            pregnancy = p;
        }
        public new string MySex()
        {
            return "женский";
        }

        public bool IsPregnant()
        {
            return pregnancy;
        }

        public void SetPregnant()
        {
            pregnancy = true;
        }
    }
}
