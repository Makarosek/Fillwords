using System;

namespace Fillwords
{
    public class Menu
    {
        private Button[] buttons;
        private int number;

        public Menu(string[] buttonsNames)
        {
            buttons = new Button[buttonsNames.Length];
            for (int i = 0; i < buttonsNames.Length; i++)
            {
                buttons[i] = new Button(buttonsNames[i]);
            }
            
        }

        public void StartMenu()
        {
            ConsoleKeyInfo key;

            do
            {
                Printer.PrintMenu(buttons, number);
                
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    number--;
                }

                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    number++;
                }

                if (number < 0)
                    number = buttons.Length - 1;
                if (number > buttons.Length - 1)
                    number = 0;


            } while (key.Key != ConsoleKey.Enter);
        }

        public int GetSelectedID()
        {
            return number;
        }
    }
}