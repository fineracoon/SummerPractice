using System;
using System.Collections.Generic;

namespace AnimalGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            Hen h1 = new Hen("Курица", "Зерно", 0, "кориченый", "Сибрайт");
            Parrot p1 = new Parrot("Попугай", "Зерно", 1, "черный", "Какаду");

            Group<IBird> g1 = new Group<IBird>("Птицы");
            g1.arr.Add(h1);
            g1.arr.Add(p1);
            Console.WriteLine(g1.Name);

            Hen h2 = h1.MakeAChild();
            g1.arr.Add(h2);
            
            foreach (IBird bird in g1.arr)
            {
                bird.PrintInfo();
                Console.WriteLine("--------------------");
            }
            h2.GrowUp(h1);
            Console.WriteLine("Цыпленок вырос");
            h2.PrintInfo();

            Console.WriteLine();

            Llama l1 = new Llama("Лама", "Трава", 0, "Бежевый", "Лама");
            Horse ho1 = new Horse("Конь", "Сено", 1, "Коричневый", "Лошадь Пржевальского");
            Group<IWithHooves> g2 = new Group<IWithHooves>("Копытные");
            Console.WriteLine(g2.Name);
            g2.arr.Add(l1);
            g2.arr.Add(ho1);

            foreach (IWithHooves hoovers in g2.arr)
            {
                hoovers.PrintInfo();
                Console.WriteLine("Голос: " + hoovers.Voice);
                Console.WriteLine("--------------------");
            }

            Console.ReadKey();
        }
    }
}
