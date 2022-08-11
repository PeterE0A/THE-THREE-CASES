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
                

                    FodboldLogic FodboldLogic = new FodboldLogic();
                    Main_menu main = new Main_menu();

                //while-løkke for at starte fodboldprogrammet igen, når du er færdig med at bruge det

                
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
                    string mål = Convert.ToString(Console.ReadLine());
                


                //indtast hvor mange afleveringer

                Console.SetCursorPosition(45, 12);
                    Console.Write("afleveringer: ");
                    int afleveringer = Convert.ToInt32(Console.ReadLine());
                    

                    Console.SetCursorPosition(45, 14);

                //hvis afleveringer er 10 vil den kalde HighFive-metoden


                Console.WriteLine(FodboldLogic.mÅL(mål, afleveringer));

       



                

               


                Console.ReadKey();
          
               
                    Console.Clear();

                    main.Menu();

                    Console.ReadKey();
            }

        }
    }
}
