using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ALL_ClassLibrary;

namespace THE_THREE_CASES
{
    public class Program
    {

        public static void Main(string[] args)
        {

            //Metode, der fører dig til login/tilmeldingssiden

            LoginMenu LoginMenu = new LoginMenu();
            LoginMenu.RunPasswordMenu();
            
            
        }
    }
}
