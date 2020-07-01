using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Animal : IAnimal
    {
        private string animalKind;
        private string consumedFood;
        private byte gender;

        public Animal(string kind, string food, byte g)
        {
            animalKind = kind;
            consumedFood = food;
            gender = g;
        }

        public string Kind
        {
            get { return animalKind; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                animalKind = value;
            }
        }

        public string Food
        {
            get { return consumedFood; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                consumedFood = value;
            }
        }

        public byte Gender
        {
            get { return gender; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Животное " + this.Kind + '\r' + '\n' +
                              "Потребляемая пища " + this.Food);
        }
    }
}
