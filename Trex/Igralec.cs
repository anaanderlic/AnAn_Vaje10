using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letala
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
            return this.Tocke.CompareTo(igralec.Tocke);
        }

    }
}
