using System;
using System.Collections.Generic;
using System.Text;

namespace HumanTask
{
    class Human
    {
        private string name;
        private int age;
        private Gender gender;

        public Human(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public enum Gender
        {
            Straight,
            Lesbian,
            Gay,
            Bisexual,
            Transgender,
            Queer,
            Other
        };

        public string MySex()
        {
            return null;
        }

        public string toString()
        {
            return "Имя " + this.name +
                   ", возраст " + this.age +
                   ", гендер " + this.gender.ToString();
        }
    }
}
