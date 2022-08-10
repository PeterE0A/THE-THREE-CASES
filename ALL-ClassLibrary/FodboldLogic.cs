using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_ClassLibrary
{
    public class FodboldLogic
    {
        public string afleveringerT;

        public string HowMuchDoWeCheer(int afleveringer, int mål)
        {



            if (afleveringer >= 10)
            {
                return "High Five – Jubel!!!";

            }
            else if (afleveringer < 1 && mål == 0)
            {
                return "Shh";

            }

            //should be in another method

            else if (mål == 1)
            {
                return "Olé olé olé";

            }
            //----------------------------------------
            else
            {
                for (int i = 0; i < afleveringer; i++) afleveringerT += "Huh! ";

                return afleveringerT;
            }


        }

        //public void Mål(string mål)
        //{
        //    bool Uppercase = mål.Any(char.IsUpper);
        //    bool Lowercase = mål.Any(char.IsLower);

        //    if (Uppercase == Lowercase)
        //    {
        //        Console.WriteLine("Olé olé olé");
        //    }
        //    else
        //    {
        //        Console.Clear();
        //    }
        //}













        ////HighFIVE Metode
        //public void HighFIVE()
        //{
        //    //hvis afleveringer er 10 vil den skrive "High Five – Jubel!!!"


        //        Console.Write("High Five – Jubel!!!");
        //        Console.ReadLine();
        //        Console.Clear();
        //}

        ////huh Metode
        //public void huh()
        //{
        //    int afleveringer = 10;

        //    //hvis afleveringer er mindre end eller lig med 10 vil den skrive "Huh!"

        //    if (afleveringer <= 10)
        //    {
        //        Console.Write("Huh!");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }
        //}


        ////OLE Metode
        //public void OLE()
        //{
        //    int mål = 1;

        //    //hvis mål er 1 vil den skrive "Olé olé olé"

        //    if (mål == 1)
        //    {
        //        Console.Write("Olé olé olé");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }


        //}


        ////SHH Metode

        //public void SHH()
        //{
        //    int afleveringer = 0;

        //    //hvis afleveringer er 0 vil den skrive "Shh"

        //    if (afleveringer == 0)
        //    {
        //        Console.Write("Shh");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }


        //}








    }

}
