using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLigueConsole
{
    public class Trou
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int distance;

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        private int par;

        public int Par
        {
            get { return par; }
            set { par = value; }
        }

        public Trou()
        {

        }

        public Trou(int c, int d, int p)
        {
            this.numero = c;
            this.distance = d;
            this.par = p;
        }

        public string ToString()
        {
            return " TROU N° : "+ this.numero + " ---- " + this.distance + "m ---- PAR : " + this.par;
        }

    }
}
