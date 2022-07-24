using System;

namespace CashMachine
{
    /// <summary>
    /// Menu between different languages.
    /// </summary>
    public class Menu
    {
        #region Components
        public English EnglishObj = new English();
        #endregion
        public Menu() { }
        public void MenuHandler()
        {
            Console.WriteLine("Welcome! / willkommen! / Witaj!");
            Console.WriteLine("Please choose a language / Bitte wählen Sie eine Sprache / Proszę wybrać język");
            Console.Write(" 1 - English /");
            Console.Write(" 2 - Deutsch /");
            Console.Write(" 3 - Polski /");
            int l = (Convert.ToInt32(Console.ReadLine()));
            switch (l)
            {
                case 1:
                    EnglishObj.MenuE();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

    }
}
