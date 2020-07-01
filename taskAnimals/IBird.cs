using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGroups
{
    interface IBird : IAnimal
    {
        string Feathers { get; set; }
        string Voice { get; }
        string Breed { get; set; }
        void PrintInfo();
    }
}
