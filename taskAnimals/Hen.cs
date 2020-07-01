using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    internal class Hen : Animal, IBird
    {
        public Hen(string kind, string food, byte g, string color, string breed) : base(kind, food, g)
        {
            Feathers = color;
            Breed = breed;
        }

        public string Feathers { get; set; }
        public string Voice
        {
            get
            {
                return "ко-ко-ко";
            }
        }
        public string Breed { get; set; }

        public Hen MakeAChild()
        {
            Random random = new Random();
            return new Hen("Цыпленок", "Зерно", (byte)random.Next(0, 1), "Желтый", this.Breed);
        }

        public void GrowUp(Object parent)
        {
            Kind = this.Gender == 0 ? "Курица" : "Петух";
            Feathers = ((Hen)parent).Feathers;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Цвет оперения " + this.Feathers + '\r' + '\n' +
                              "Голос: " + this.Voice + '\r' + '\n' + 
                              "Порода " + this.Breed);
        }
    }
}
