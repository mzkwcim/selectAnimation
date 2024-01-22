using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class SupportingSystem
    {
        public static void DrawAndErase(int y, int x = 10)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
            Thread.Sleep(100);
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
        public static void ChangeColorToDarkCyanAndClear()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
        }
        public static void ConsoleReadKeyAndClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
