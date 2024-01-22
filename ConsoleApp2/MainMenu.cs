using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class MainMenu
    {
        public static string[] menu = new string[] { "Menu - Please Select", "1. Draw Borders", "2. Loading Line", "3. Loading Percentage", "4. Loading Cursor", "5. Up-Down Animation", "6. Screen Bouncing Animation", "7. Quit" };
        static void Main()
        {
            int number = 0;
            while (number != 7)
            {
                number = MainMenuInteractionSystem.Highlight(number);
                switch (number)
                {
                    case 1: Animations.Borders(); break;
                    case 2: Animations.LoadingLine(); break;
                    case 3: Animations.LoadingPercentage(); break;
                    case 4: Animations.LoadingCursor(); break;
                    case 5: Animations.UpDownAnimation(); break;
                    case 6: Animations.ScreenBounceAnimation(); break;
                    case 7: Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); break;
                    default: break;
                }
            }
        }
    }
}
