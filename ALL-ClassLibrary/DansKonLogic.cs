using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_ClassLibrary
{
    public class DansKonLogic
    {
        public string Name;
        public int Score;

        //NAME Metode til at hente navn

        public void NAME(string name)
        {
            this.Name = name;
        }

        //SetNAME Metode til at returnere navn
        public string SetNAME()
        {
            return this.Name;
        }

        //SCORE Metode til at hente score

        public void SCORE(int score)
        {
            this.Score = score;
        }

        //SetSCORE Metode til at returnere score

        public int SetSCORE()
        {
            return this.Score;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DansKonLogic);
        }

        public bool Equals(DansKonLogic other)
        {
            return other != null &&
                   Name == other.Name &&
                   Score == other.Score;
        }

        public override int GetHashCode()
        {
            int hashCode = -1744016341;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            return hashCode;
        }

        public static bool operator == (DansKonLogic left, DansKonLogic right)
        {
            return EqualityComparer<DansKonLogic>.Default.Equals(left, right);
        }

        public static bool operator !=(DansKonLogic left,DansKonLogic right)
        {
            return !(left == right);
        }

    }
}
