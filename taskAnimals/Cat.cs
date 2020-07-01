using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Cat : Animal, IHunter
    {
        public Cat(string kind, string food, byte gender, string bre, string hairColor) : base(kind, food, gender)
        {
            Breed = bre;
            FurColor = hairColor;
        }

        public string FurColor { get; set; }
        public string Breed { get; set; }
        public string Voice
        {
            get
            {
                return "мяу";
            }
        }

        public void GrowUp(object parent)
        {
            Kind = this.Gender == 0 ? "Кошка" : "Кот";
            this.Food = "Мясо";
        }

        public object MakeAChild()
        {
            Random random = new Random();
            return new Cat("Котенок", "Молоко", (byte)random.Next(0, 1), this.Breed, this.FurColor);
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Цвет шерсти " + this.FurColor + '\r' + '\n' +
                              "Порода " + this.Breed);
        }
    }
}
