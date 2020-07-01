using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    interface IHunter : IAnimal
    {
        string FurColor { get; set; }
        string Breed { get; set; }
        string Voice { get; }
        void PrintInfo();
    }
}
