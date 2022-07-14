using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;

namespace THE_THREE_CASES
{
    public class Fodbold
    {
        public void FODBOLD()
        {
            {
                int b = 2;

                FodboldLogic FodboldLogic = new FodboldLogic();

                while (b == 2)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Fodbold ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("MÅL: ");
                    int mål = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(45, 12);
                    Console.Write("afleveringer: ");
                    int afleveringer = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(45, 14);
                    if (afleveringer == 10)
                    {

                        FodboldLogic.HighFIVE();
                    }
                    else if (mål == 1)
                    {
                        FodboldLogic.OLE();
                    }
                    else if (afleveringer == 0)
                    {
                        FodboldLogic.SHH();
                    }
                    else if (afleveringer <= 10)
                    {
                        FodboldLogic.huh();

                    }


                    Console.Clear();

                }

                Console.ReadKey();
            }

        }
    }
}
