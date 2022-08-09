using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_ClassLibrary
{
    public class FodboldLogic
    {

        //HighFIVE Metode
            public void HighFIVE()
            {

                int afleveringer = 10;

            //hvis afleveringer er 10 vil den skrive "High Five – Jubel!!!"

            if (afleveringer == 10)
                {
                    Console.Write("High Five – Jubel!!!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        //huh Metode
        public void huh()
        {
            int afleveringer = 10;

            //hvis afleveringer er mindre end eller lig med 10 vil den skrive "Huh!"

            if (afleveringer <= 10)
            {
                Console.Write("Huh!");
                Console.ReadLine();
                Console.Clear();
            }
        }


        //OLE Metode
        public void OLE()
            {
                int mål = 1;

            //hvis mål er 1 vil den skrive "Olé olé olé"

            if (mål == 1)
                {
                    Console.Write("Olé olé olé");
                    Console.ReadLine();
                    Console.Clear();
                }


            }


        //SHH Metode

        public void SHH()
            {
                int afleveringer = 0;

            //hvis afleveringer er 0 vil den skrive "Shh"

            if (afleveringer == 0)
                {
                    Console.Write("Shh");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
       







    }

}
