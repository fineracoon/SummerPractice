using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Parrot : Animal, IBird
    {
        public Parrot(string kind, string food, byte gender, string feathers, string bre) : base(kind, food, gender)
        {
            Breed = bre;
            Feathers = feathers;
        }

        public string Feathers { get; set; }
        public string Voice 
        { 
            get
            {
                return "*звуки попугая*";
            }
        }
        public string Breed { get; set; }

        public void GrowUp(object parent)
        {
            Kind = this.Gender == 0 ? "Самка попугая" : "Самец попугая";
            Feathers = ((Parrot)parent).Feathers;
        }

        public object MakeAChild()
        {
            Random random = new Random();
            return new Parrot("Птенец попугая", "Зерно", (byte)random.Next(0, 1), this.Breed, "нет"); ;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Цвет оперения " + this.Feathers + '\r' + '\n' +
                              "Порода " + this.Breed);
        }
    }
}
