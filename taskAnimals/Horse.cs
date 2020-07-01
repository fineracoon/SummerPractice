using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    class Horse : Animal, IWithHooves
    {
        public Horse(string kind, string food, byte gender, string skin, string bre) : base(kind, food, gender)
        {
            Breed = bre;
            FurColor = skin;
        }

        public string Breed { get; set; }
        public string FurColor { get; set; }
        public string Voice {
            get
            {
                return "и-го-го";
            }
        }

        public void GrowUp(object parent)
        {
            Kind = this.Gender == 0 ? "Лошаль" : "Конь";
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Окрас " + this.FurColor + '\r' + '\n' +
                              "Порода " + this.Breed);
        }
    }
}
