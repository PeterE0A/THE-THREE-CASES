using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;


namespace THE_THREE_CASES
{
    public class DanseKon
    {

        //DANSE Metode
        public void DANSE()
        {


                Main_menu main = new Main_menu();
       


            //tilføjer baggrund og skriftfarve for at få det til at se pænere ud

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                //titel

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- DanseKonkurrence ----------");


                DansKonLogic danser1 = new DansKonLogic();

                //indtast danserens navn

                Console.SetCursorPosition(45, 10);
                Console.Write("First Dancer: ");
                danser1.NAME(Console.ReadLine());

                //indtast danserens score

                Console.SetCursorPosition(45, 12);
                Console.Write("Score: ");
                danser1.SCORE(Convert.ToInt32(Console.ReadLine()));


                DansKonLogic danser2 = new DansKonLogic();

                //indtast danserens navn

                Console.SetCursorPosition(45, 14);
                Console.Write("Second Dancer: ");
                danser2.NAME(Console.ReadLine());

                //indtast danserens score


                Console.SetCursorPosition(45, 16);
                Console.Write("Score: ");
                danser2.SCORE(Convert.ToInt32(Console.ReadLine()));

                Console.Clear();

                //titel

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- DanseKonkurrence ----------");

                //første danser og anden danser med deres score (samlede)

                Console.SetCursorPosition(45, 10);
                Console.Write(danser1.SetNAME() + " " + "& " + danser2.SetNAME() + " " + (danser1.SetSCORE() + danser2.SetSCORE()));

                Console.ReadKey();


                main.Menu();




                Console.ReadKey();
            

        }
    }
}
