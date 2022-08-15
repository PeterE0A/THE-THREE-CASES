using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;
using THE_THREE_CASES;


namespace THE_THREE_CASES
{
    public class DanseKon
    {

        //DANSE Metode
        public void DANSE()
        {
            

            Main_menu main = new Main_menu();
            //DansKonLogic danser1 = new DansKonLogic();
            //DansKonLogic danser2 = new DansKonLogic();
            
         
           

            //tilføjer baggrund og skriftfarve for at få det til at se pænere ud

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //titel

            Console.SetCursorPosition(45, 7);
            Console.Write("---------- DanseKonkurrence ----------");


          
            //indtast danserens 1 navn

            Console.SetCursorPosition(45, 10);
            Console.Write("First Dancer: ");
            //danser1.NAME(Console.ReadLine());
            string name1 = Console.ReadLine();

            //indtast danserens 1 score

            Console.SetCursorPosition(45, 12);
            Console.Write("Score: ");
            //danser1.SCORE(Convert.ToInt32(Console.ReadLine()));
            int points1 = Convert.ToInt32(Console.ReadLine());

            DansKonLogic dancer1 = new DansKonLogic(name1, points1);


            //indtast danserens 2 navn

            Console.SetCursorPosition(45, 14);
            Console.Write("Second Dancer: ");
            //danser2.NAME(Console.ReadLine());
            string name2 = Console.ReadLine();

            //indtast danserens 2 score


            Console.SetCursorPosition(45, 16);
            Console.Write("Score: ");
            //danser2.SCORE(Convert.ToInt32(Console.ReadLine()));
            int points2 = Convert.ToInt32(Console.ReadLine());

            DansKonLogic dancer2 = new DansKonLogic(name2, points2);


            Console.Clear();

            //titel

            Console.SetCursorPosition(45, 7);
            Console.Write("---------- DanseKonkurrence ----------");

            //første danser og anden danser med deres score (samlede)

            Console.SetCursorPosition(45, 10);
            //Console.Write(danser1.SetNAME() + " " + "& " + danser2.SetNAME() + " " + (danser1.SetSCORE() + danser2.SetSCORE()));
            DansKonLogic total = dancer1 + dancer2;
            Console.WriteLine(total.name + " " + total.points);

            //Console.WriteLine(Object.name + object.score);

            Console.ReadKey();


            main.Menu();




            Console.ReadKey();


        }
    }
}
