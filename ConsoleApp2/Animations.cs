using projekt;

class Animations
{
    
    public static void Borders()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            for (int j = 0; j < Console.WindowWidth - 1; j++)
            {
                if (i == 0 | i == Console.WindowHeight - 1)
                {
                    Console.Write("#");
                }
            }
            Console.Write("#");
            Console.CursorLeft = Console.WindowWidth - 1;
            Console.Write("#\n");
        }
        SupportingSystem.ConsoleReadKeyAndClear();
    }
    public static void LoadingCursor()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        Console.CursorLeft = 55;
        string[] tablica = new string[] { "|", "/", "-", "\\" };
        Console.Write("Loading ");
        for (int i = 0; i < tablica.Length * 20; i++)
        {
            Console.Write(tablica[i % 4]);
            Thread.Sleep(100);
            Console.CursorLeft = 63;
        }
        SupportingSystem.ConsoleReadKeyAndClear();
    }
    public static void LoadingLine()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("#");
            Thread.Sleep(100);
        }
        SupportingSystem.ConsoleReadKeyAndClear();
    }
    public static void LoadingPercentage()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        Console.WriteLine();
        for (int i = 0; i < Console.WindowWidth + 1; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = 49;
            Console.Write("Loading " + i * 100 / Console.WindowWidth + "% completed\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (i < 120)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("#");
            }
            Console.SetCursorPosition(49, 1);
            Thread.Sleep(150);
        }
        SupportingSystem.ConsoleReadKeyAndClear();
    }
    public static void UpDownAnimation()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        int y = 1;
        int dy = 1;
        while (!Console.KeyAvailable)
        {
            SupportingSystem.DrawAndErase(y);
            dy = (y <= 0 || y > Console.WindowHeight - 2) ? -dy : dy;
            y += dy;
        }
    }
    public static void ScreenBounceAnimation()
    {
        SupportingSystem.ChangeColorToDarkCyanAndClear();
        Console.Write("#");
        Console.Clear();
        int x = 1;
        int y = 1;
        int dx = 1;
        int dy = 1;
        while (!Console.KeyAvailable)
        {
            SupportingSystem.DrawAndErase(y, x);
            dx = (x <= 0 || x > Console.WindowWidth - 2) ? -dx : dx;
            dy = (y <= 0 || y > Console.WindowHeight - 2) ? -dy : dy;
            x += dx;
            y += dy;
        }
    }  
}
