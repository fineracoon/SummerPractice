using System;
using System.Collections.Generic;
using System.Text;

namespace HumanTask
{
    class Boy : Human
    {
        private string favoriteGame;

        public Boy(string name, int age, Gender gender, string game) : base(name, age,  gender)
        {
            favoriteGame = game;
        }
        public new string MySex()
        {
            return "мужской";
        }

        public string FavGame()
        {
            return favoriteGame;
        }

        public void ChangeGame(string game)
        {
            favoriteGame = game;
        }

        public string ThinkingAbout()
        {
            return "nothing.";
        }
    }
}
