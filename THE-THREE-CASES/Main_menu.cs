using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;
using System.IO;

namespace THE_THREE_CASES
{
    public class Main_menu
    {

        //objekter

        Fodbold Fodbold = new Fodbold();    
        DanseKon DanseKon = new DanseKon();


        //metode til hovedmenuen

        public void Menu()
        {



            start:

            //tilføjer baggrund og skriftfarve for at få det til at se pænere ud

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //titel

            Console.SetCursorPosition(45, 7);
            Console.Write("---------- Welcome ----------");

            //vælg en for fodbold og to for DabseKonkurrence

            Console.SetCursorPosition(45, 10);
            Console.Write("Choose by Typing 1 or 2:");
            Console.SetCursorPosition(45, 12);
            Console.Write("1. Fodbold");

            Console.SetCursorPosition(45, 14);
            Console.Write("2. DanseKonkurrence");
            Console.SetCursorPosition(70, 10);

            //læs hvad du har indtastet

            int choose = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            //hvis du indtastede 1, går det til fodboldprogrammet

            if (choose == 1)
            {
                Fodbold.FODBOLD();
            }

            //hvis du indtastede 2 går det til danseprogrammet

            else if (choose == 2)
            {

                DanseKon.DANSE();
  
            }

            //ellers går den til start (velkomstside ) som øverst

            else
            {

                goto start;
                
            }
            Console.ReadKey();


        }
    }
}
