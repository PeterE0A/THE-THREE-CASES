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
        Fodbold Fodbold = new Fodbold();    
        DanseKon DanseKon = new DanseKon();


        

        public void Menu()
        {
            start: 

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.SetCursorPosition(45, 7);
            Console.Write("---------- Welcome ----------");


            Console.SetCursorPosition(45, 10);
            Console.Write("Choose by Typing 1 or 2:");
            Console.SetCursorPosition(45, 12);
            Console.Write("1. Fodbold");

            Console.SetCursorPosition(45, 14);
            Console.Write("2. DanseKonkurrence");
            Console.SetCursorPosition(70, 10);
            int choose = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
             



            if (choose == 1)
            {
                Fodbold.FODBOLD();
            }
            else if (choose == 2)
            {

                DanseKon.DANSE();
  
            }
            else
            {

                goto start;
                
            }
            Console.ReadKey();


        }
    }
}
