using System;
namespace Fillwords
{
    public class Printer
    {
        public static void Print(bool select, string name)
        {
            if (select)
                Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine(name);
            Console.ResetColor();
        }
        
        public static void PrintMenu(Button[] buttons, int number)
        {
            Console.Clear();
            for (var index = 0; index < buttons.Length; index++)
            {
                Button button = buttons[index];
                Print(number == index, button.Name);
            }
        }
    }
}