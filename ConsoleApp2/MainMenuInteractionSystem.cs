using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class MainMenuInteractionSystem
    {
        public static void Color()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(MainMenu.menu[Console.CursorTop]);
        }
        public static void DrawMenu()
        {
            SupportingSystem.ChangeColorToDarkCyanAndClear();
            foreach (string element in MainMenu.menu)
            {
                Console.WriteLine(element);
            }
            Console.SetCursorPosition(0, 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(MainMenu.menu[Console.CursorTop]);
        }
        public static int Highlight(int number)
        {
            ConsoleKey key;
            DrawMenu();
            do
            {
                Console.CursorVisible = false;
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    UnColor();
                    MoveUp();
                    Color();
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    UnColor();
                    MoveDown();
                    Color();
                }
                else if (key == ConsoleKey.Enter)
                {
                    number = Console.CursorTop;
                }
            } while (key != ConsoleKey.Enter);
            return number;
        }
        public static void MoveUp() => Console.CursorTop = (Console.CursorTop - 1 < 1) ? MainMenu.menu.Length - 1 : (Console.CursorTop - 1) % MainMenu.menu.Length;
        public static void MoveDown() => Console.CursorTop = ((Console.CursorTop + 1) % MainMenu.menu.Length == 0) ? 1 : (Console.CursorTop + 1) % MainMenu.menu.Length;
        public static void UnColor()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(MainMenu.menu[Console.CursorTop]);
        }
    }
}
