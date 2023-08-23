using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Rex
{
    public class Igralec : IComparable
    {
        public string Ime
        {
            get;
            set;
        }

        public int Tocke
        {
            get;
            set;
        }
        public int CompareTo(object objekt)
        {
            Igralec igralec = objekt as Igralec;
            return igralec.Tocke.CompareTo(this.Tocke);
        }

    }
}
