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

            //LoginLogic Login = new LoginLogic();
            //Login.Login();

            LoginMenu LoginMenu = new LoginMenu();
            LoginMenu.RunPasswordMenu();
            //Main_menu main = new Main_menu();
            //main.Menu();
            
        }
    }
}
