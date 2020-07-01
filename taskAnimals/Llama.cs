using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Llama : Animal, IWithHooves
    {
        public string Breed { get; set; }
        public string FurColor { get; set; }
        public string Voice
        {
            get
            {
                return "*звуки ламы*";
            }
        }

        public Llama(string kind, string food, byte gender, string color, string breed) : base(kind, food, gender)
        {
            FurColor = color;
            Breed = breed;
        }

        public void GrowUp(object parent)
        {
            Kind = this.Gender == 0 ? "Овца" : "Баран";
            FurColor = ((Llama)parent).FurColor;
        }

        public object MakeAChild()
        {
            Random random = new Random();
            return new Llama("Детеныш ламы", "Сено", (byte)random.Next(0, 1), this.FurColor, this.Breed);
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Цвет шерсти " + this.FurColor + '\r' + '\n' + 
                              "Порода " + this.Breed);
        }
    }
}
