using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    interface IWithHooves : IAnimal
    {
        string Breed { get; set; }
        string FurColor { get; set; }
        string Voice { get; }
        void PrintInfo();
    }
}
