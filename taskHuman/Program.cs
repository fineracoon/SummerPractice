using System;

namespace HumanTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl g1 = new Girl("Сэнди", 17, Human.Gender.Lesbian, false);
            Boy b1 = new Boy("Боб", 24, Human.Gender.Straight, "Skyrim");

            Console.WriteLine(g1.toString());
            Console.WriteLine("Пол " + g1.MySex());
            if (g1.IsPregnant())
                Console.WriteLine("Не беременна");
            else
                Console.WriteLine("Беременна");
            g1.SetPregnant();

            Console.WriteLine(b1.toString());
            Console.WriteLine("Пол " + b1.MySex() + ", думает о " + b1.ThinkingAbout());
            Console.WriteLine("Любимая игра " + b1.FavGame());

            Console.ReadKey();
        }
    }
}
