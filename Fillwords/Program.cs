using System;
using System.Collections.Generic;


namespace Fillwords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ConsoleKeyInfo key;
            int left = 0, top = 0;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(left, top);

                Console.WriteLine(">");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow) left--;
                if (key.Key == ConsoleKey.RightArrow) left++;
                if (key.Key == ConsoleKey.DownArrow) top--;
                if (key.Key == ConsoleKey.UpArrow) top++;

                if (left < 0) left = 0;
                if (top < 0) top = 0;
            } 
            while (key.Key != ConsoleKey.Escape);*/
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
