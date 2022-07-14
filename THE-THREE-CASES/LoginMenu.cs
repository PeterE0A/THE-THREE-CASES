using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;


namespace THE_THREE_CASES
{
    internal class LoginMenu
    {
        public void RunPasswordMenu()
        {
            string brugernavnFilepath = @"C:\SkrivBord\Brugernavn.txt"; // Username file path
            string adgangskodeFilepath = @"C:\SkrivBord\Adgangskode.txt"; // Username file path

            PasswordLogic Password = new PasswordLogic();
            PasswordLogic PasswordLogic = new PasswordLogic();


            bool Continue = false;

            while (Continue == false)
            {


                
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- Login / Sign-Up ----------");

                Console.SetCursorPosition(45, 10);
                Console.Write("Choose by Typing 1 or 2:");
                Console.SetCursorPosition(45, 12);
                Console.Write("1. Login");

                Console.SetCursorPosition(45, 14);
                Console.Write("2. Sign-Up");
                Console.SetCursorPosition(70, 10);
                
                var choice = Console.ReadLine();


                Console.Clear();
                if (choice == "1")
                {
                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Login ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                }
                if (choice == "2")
                {
                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Sign-Up ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    PasswordLogic f = new PasswordLogic();
                    var d = f.PasswordRequiremnts(password, user);

                    if (d == "")
                    {
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("Welcome " + user + " " + "you have created a new account");
                        Console.Clear();

                        Console.SetCursorPosition(45, 7);
                        Console.Write("----------Try Logging in with your new Account ----------");

                        Console.SetCursorPosition(45, 10);
                        Console.Write("User: ");
                        user = Console.ReadLine();

                        Console.SetCursorPosition(45, 12);
                        Console.Write("Password: ");
                        password = Console.ReadLine();
                        File.WriteAllText(brugernavnFilepath, user);
                        File.WriteAllText(adgangskodeFilepath, password);
                        Console.Clear();



                       
                        d = f.PasswordRequiremnts(password,user);





                        Main_menu main = new Main_menu();
                            main.Menu();

                        


                        




                        Console.Clear();



                    }
                    else
                    {
                        Console.WriteLine($"{d}");
                    }
                }






                //File.WriteAllText(filepath, user + "     " + password);



                //Password.PasswordRequiremnts(password);

                //if (asldklsad)
                //{
                //    Continue = true;


                //    File.ReadAllText(filepath);

                //}


                Console.ReadKey();
            }
        }
    }
}
