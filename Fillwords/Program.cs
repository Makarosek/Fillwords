using System;

namespace Fillwords
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu(new []{"Новая игра", "Продолжить", "Рейтинг", "Выход"});
            mainMenu.StartMenu();

            switch (mainMenu.GetSelectedID())
            {
                case 0:
                    Console.WriteLine("Тут могла бы бть игра, но я цветочный.");
                    break;
                case 1:
                    Console.WriteLine("Сначала начни, чтобы продолжить."); 
                    break;
                case 2:
                    Console.WriteLine("Рейтинг появится после первой игры.");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
