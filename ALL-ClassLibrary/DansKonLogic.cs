using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ALL_ClassLibrary
{
    public class DansKonLogic
    {

        public string name;
        public int points;

        //constructor
        public DansKonLogic(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DansKonLogic operator +(DansKonLogic a, DansKonLogic b)
        {
            string n = a.name + " & " + b.name;
            int p = a.points + b.points;
            DansKonLogic result = new DansKonLogic(n, p);
            return result;
        }

  

    }
   
}
