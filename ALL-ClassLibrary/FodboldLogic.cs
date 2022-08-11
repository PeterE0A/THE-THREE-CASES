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

        //metode til at se, hvad der skal jubles baseret på, hvilket input der er indtastet

        public string HowMuchDoWeCheer(int afleveringer)
        {



            if (afleveringer >= 10)
            {
                return "High Five – Jubel!!!";

            }
            else if (afleveringer < 1)
            {
                return "Shh";

            }

            else
            {
                for (int i = 0; i < afleveringer; i++) afleveringerT += "Huh! ";

                return afleveringerT;
            }


        }

        //metode til, hvad der skal jubles, når der scores et mål
        public string mÅL(string mål, int afleveringer)

        {
            bool OneUppercase = mål.Any(char.IsUpper);
            bool OneLowercase = mål.Any(char.IsLower);


            if (OneUppercase && OneLowercase || OneLowercase != OneUppercase)
            {

                return "Olé olé olé";

            }
            else
            {
                return HowMuchDoWeCheer(afleveringer);
            }          
           
        }

    }

}
