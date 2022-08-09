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

        //metode til fodboldprogrammet
        public void FODBOLD()
        {
            {
                int b = 2;

                FodboldLogic FodboldLogic = new FodboldLogic();

                //while-løkke for at starte fodboldprogrammet igen, når du er færdig med at bruge det

                while (b == 2)
                {

                    //tilføjer baggrund og skriftfarve for at få det til at se pænere ud

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    //titel

                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Fodbold ----------");

                    //indtast hvor mange mål

                    Console.SetCursorPosition(45, 10);
                    Console.Write("MÅL: ");
                    int mål = Convert.ToInt32(Console.ReadLine());

                    //indtast hvor mange afleveringer

                    Console.SetCursorPosition(45, 12);
                    Console.Write("afleveringer: ");
                    int afleveringer = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(45, 14);

                    //hvis afleveringer er 10 vil den kalde HighFive-metoden

                    if (afleveringer == 10)
                    {

                        FodboldLogic.HighFIVE();
                    }

                    //hvis mål er 1 vil det kalde OLE-metoden

                    else if (mål == 1)
                    {
                        FodboldLogic.OLE();
                    }

                    //hvis afleveringer er 0 vil den kalde SHH-metoden

                    else if (afleveringer == 0)
                    {
                        FodboldLogic.SHH();
                    }

                    //hvis afleveringer er mindre end eller lig med 10 vil den kalde huh-metoden

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
