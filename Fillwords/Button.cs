using System;

namespace Fillwords
{
    public class Button
    {
        private string name;

        public Button(string name)
        {
            this.name = name;
        }

        public void Print(bool select)
        {
            if (select) 
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            
            Console.WriteLine(name);
            Console.ResetColor();
        }
    }
}