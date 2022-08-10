using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;


namespace THE_THREE_CASES
{
    public class LoginMenu
    {
        
        public void RunPasswordMenu()
        {
            

            string brugernavnFilepath = @"C:Brugernavn.txt"; // Username file path
            string adgangskodeFilepath = @"C:Adgangskode.txt"; // Username file path


            Main_menu main = new Main_menu(); 


            

            bool Continue = false;

            //While-løkke, der fører dig til samme side, hvis noget blev skrevet forkert eller ej, eller hvad der blev bedt om

            while (Continue == false)
            {

                //tilføjer baggrund og skriftfarve for at få det til at se pænere ud

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                //titel

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- Login / Sign-Up ----------");

                //vælg en for at logge ind og to for at tilmelde dig

                Console.SetCursorPosition(45, 10);
                Console.Write("Choose by Typing 1 or 2:");

                Console.SetCursorPosition(45, 12);
                Console.Write("1. Login");

                Console.SetCursorPosition(45, 14);
                Console.Write("2. Sign-Up");
                Console.SetCursorPosition(70, 10);

                //læs hvad du har indtastet

                var choice = Console.ReadLine();

                //rydder siden og skifter til siden afhængigt af det tal, du har indtastet

                Console.Clear();

                //hvis du indtastede 1, går den til login-siden

                if (choice == "1")
                {
                    //titel

                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Login ----------");

                    //indtast brugernavn

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    //indtast adgangskode

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    //kalder metoderne fra andre klasser og udfører en specifik handling

                    CheckCaps(user);
                    TjekHvisDetAlleredeEksisterer(user);
                    PasswordLengthandothers(password);
                    Checkifpasswordexists(password);
               
                             
                    Console.ReadLine();
                     

                   
                }

                //hvis du indtastede 2, går det til en tilmeldingsside

                if (choice == "2")
                {
                    //titel

                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Sign-Up ----------");

                    //indtast brugernavn

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    //indtast adgangskode

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    //kalder metoderne fra andre klasser og udfører en specifik handling

                    CheckCaps(user);
                    PasswordLengthandothers(password);

                    //skriver, hvad du har indtastet til tekstfil

                    File.WriteAllText(brugernavnFilepath, user);
                    File.WriteAllText(adgangskodeFilepath, password);

                    //byder dig velkommen, fordi du har oprettet en ny konto

                    Console.SetCursorPosition(45, 17);
                    Console.WriteLine("Welcome " + user + " " + "you have created a new account");
                    Console.ReadLine();
                    Console.Clear();

                    //beder dig om at logge ind med den konto, du lige har oprettet

                    Console.SetCursorPosition(45, 7);
                    Console.Write("----------Try Logging in with your new Account ----------");

                    //indtast brugernavn

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    user = Console.ReadLine();

                    //indtast adgangskode

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    password = Console.ReadLine();

                    //kalder metoderne fra andre klasser og udfører en specifik handling

                    CheckCaps(user);
                    TjekHvisDetAlleredeEksisterer(user);
                    PasswordLengthandothers(password);
                    Checkifpasswordexists(password);


                    Console.Clear();
                    

                }

               
              
                Console.ReadKey();
            }
        }

        //metode, der kontrollerer, om brugernavnet har store bogstaver
        public void CheckCaps(string user)
        {
            bool containsUppercase = user.Any(char.IsUpper);

            //hvis brugernavn har et stort bogstav, skriver det "brugernavn må ikke indeholde store bogstaver" og vender tilbage til login/tilmeldingssiden

            if (containsUppercase)
            {
                Console.SetCursorPosition(45, 16);
                Console.WriteLine("User Name should not contain any Upper Case Letters!");
                Console.ReadLine();
                RunPasswordMenu();
            }
        }


        //metode, der kontrollerer, om brugernavnet allerede eksisterer
        public void TjekHvisDetAlleredeEksisterer(string user)
        {

            //filsti til brugernavn text-fil

            string filepath = @"C:Brugernavn.txt";
            string check = File.ReadAllText(filepath);

            //hvis brugernavn eksisterer, skriver det "brugernavn eksisterer"

            if (check.Contains(user))
            {

                Console.SetCursorPosition(45, 16);
                Console.WriteLine("User Exists!");
                Console.ReadLine();
               
             
            }

            //ellers skriver den "brugernavn eksisterer ikke" og vender tilbage til login/tilmeldingssiden

            else
            {
                Console.SetCursorPosition(45, 16);
                Console.WriteLine("User Doesn't Exists! Try Again or Sign-Up!");
                Console.ReadLine();
                RunPasswordMenu();
            }
           
            
        }

        //metode, der kontrollerer, om der findes adgangskode
        public void Checkifpasswordexists(string password)
        {

            Main_menu main = new Main_menu();

            //filsti til adgangskode text-fil

            string filepath = @"C:adgangskode.txt";
            string check = File.ReadAllText(filepath);

            //hvis adgangskode eksisterer, skriver det "adgangskode eksisterer" og den flytter til hovedmenuen

            if (check.Contains(password))
            {
                Console.SetCursorPosition(45, 18);
                Console.Write("Password Exists!");
                Console.ReadLine();
                main.Menu();
                
            }

            //ellers skriver den "adgangskode eksisterer ikke" og vender tilbage til login/tilmeldingssiden

            else
            {
                Console.SetCursorPosition(45, 18);
                Console.Write("Password Doesn't Exist!");
                Console.ReadLine();
                RunPasswordMenu();
            }

        }

        //metode, der kontrollerer, om adgangskoden har en bestemt længde og har specifikke krav
        public void PasswordLengthandothers(string password)
        {


            Main_menu main = new Main_menu();

            //booleaner, strenge og heltal

            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
            string space = ("  ");
            int minLength = 12;


            //hvis adgangskodelængden er mindre end 12 tegn, vil den skrive "adgangskoden skal have minimum 12 tegn" og vender tilbage til login/tilmeldingssiden

            if (password.Length < minLength)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have minimum 12 characters!");
                Console.ReadLine ();
                RunPasswordMenu();

            }

            //hvis små bogstaver ikke er lig med store bogstaver vil den skrive "adgangskode skal have mindst et ​​stort og et lille bogstav og vender tilbage til login/tilmeldingssiden

            else if (containsAtLeastOneLowercase != containsAtLeastOneUppercase)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Upper and Lower Case Character!");
                Console.ReadLine();
                RunPasswordMenu();

            }

            //hvis adgangskoden ikke indeholder nogen specialtegn, vil den skrive "adgangskoden skal have mindst et ​​specialtegn" og vender tilbage til login/tilmeldingssiden

            else if (!Contains(password, specialChars))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Special Character!");
                Console.ReadLine();
                RunPasswordMenu();

            }

            //hvis adgangskoden har mellemrum vil den skrive "adgangskoden skal ikke have mellemrum" og vender tilbage til login/tilmeldingssiden

            else if (Contains(password, space))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should not have any Spaces!");
                Console.ReadLine();
                RunPasswordMenu();

            }
           



        }

        //metode til at kontrollere, om specifikke ting indeholder det, den skal indeholde

        public bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

    }
}
