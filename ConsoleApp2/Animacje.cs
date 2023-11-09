using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml;

class Animacje
{
    static void Main()
    {
        int hig = Console.WindowHeight;
        int wid = Console.WindowWidth;
        Console.WriteLine("Use Up and Down arrows to move, use Enter to confirm your choice");
        Console.Write("Press any key to continue");
        Console.ReadKey();
        bool koniec = true;
        while (koniec)
        {
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Menu - Please Select\n1. Draw Borders\n2. Loading Line\n3. Loading Percentage\n4. Loading Cursor\n5. Up-Down Animation\n6. Screen Bouncing Animation\n7. Quit");
            Console.SetCursorPosition(0, 1);
            ConsoleKey key;
            int number = 0;
            do
            {
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    MoveUp();
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    MoveDown();
                }
                else if (key == ConsoleKey.Enter)
                {
                    number = Console.CursorTop;
                }
            } while (key != ConsoleKey.Enter);

            switch (number)
            {
                case 1:
                    Borders(hig, wid);
                    break;

                case 2:
                    LoadingLine(wid);
                    break;

                case 3:
                    LoadingPercentage(wid);
                    break;

                case 4:
                    LoadingCursor();
                    break;

                case 5:
                    UpDownAnimation(hig);
                    break;

                case 6:
                    ScreenBounceAnimation(hig, wid);
                    break;

                case 7:
                    koniec = false;
                    break;

                default:
                    Console.Clear();
                    break;
            }
        }
    }

    public static void Borders(int hig, int wid)
    {
        Console.Clear();
        Console.CursorVisible = false;
        for(int i = 0; i < hig; i++)
        {
            for(int j = 0; j < wid-1; j++)
            {
                if (i == 0 | i == hig-1)
                {
                    Console.Write("#");
                }
            }
            Console.Write("#");
            Console.CursorLeft = wid - 1;
            Console.Write("#");
            Console.WriteLine();
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void LoadingLine(int wid)
    {
        Console.Clear();
        Console.CursorVisible = false;
        for (int i = 0; i < wid; i++)
        {
            Console.Write("#");
            Thread.Sleep(100);
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void LoadingPercentage(int wid)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine();
        for (int i = 0; i < wid + 1; i++)
        {
            int procent = i * 100 / wid;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = 49;
            Console.Write("Loading " + procent + "% completed\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (i < 120)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("#");
            }
            Console.SetCursorPosition(49, 1);
            Thread.Sleep(150);
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void LoadingCursor()
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        Console.CursorVisible = false;
        Console.CursorLeft = 55;
        string[] tablica = new string[] { "|", "/", "-", "\\" };
        Console.Write("Loading ");
        for (int i = 0; i < tablica.Length * 20; i++)
        {
            Console.Write(tablica[i % 4]);
            Thread.Sleep(100);
            Console.CursorLeft = 63;
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void UpDownAnimation(int high)
    {
        int y = 1;
        int dy = 1;
        bool koniec = true;
        Console.CursorVisible = false;
        do
        {
            if (Console.KeyAvailable)
            {
                koniec = false;
            }
            Console.SetCursorPosition(10, y);
            Console.Write("#");

            Thread.Sleep(100);

            if (y <= 0 || y > high - 2)
            {
                dy = -dy;
            }
            y += dy;
            Console.Clear();
        } while (koniec);
    }
    public static void ScreenBounceAnimation(int hig, int wid)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write("#");
        Console.Clear();
        bool koniec = true;
        int x = 1;
        int y = 1;
        int dx = 1;
        int dy = 1;
        while (koniec)
        {
            if (Console.KeyAvailable)
            {
                koniec = false;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("#");
            Thread.Sleep(100);
            Console.Clear();
            if (x <= 0 || x > wid - 2)
            {
                dx = -dx;
            }

            if (y <= 0 || y > hig - 2)
            {
                dy = -dy;
            }

            x += dx;
            y += dy;
        }


    }
    public static void MoveUp()
    {
        int Top = Console.CursorTop;
        if (Top - 1 < 1)
        {
            Console.SetCursorPosition(0, 7);
        }
        else
        {
            Console.SetCursorPosition(0, (Top - 1) % 8);
        }
    }
    public static void MoveDown()
    {
        int Top = Console.CursorTop;
        if ((Top + 1)%8 == 0)
        {
            Console.SetCursorPosition(0, 1);
        }
        else
        {
            Console.SetCursorPosition(0, (Top + 1) % 8);
        }

    }
}