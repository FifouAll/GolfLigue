using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLigueConsole
{
    /*
     * CLASSE CLUB :représente un club de golf
     * CREE par : ED
     * LE : 10/10/2014
     **/
    public class Club
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string rue;

        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }
        private string cp;

        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private double gps_lat;

        public double Gps_lat
        {
            get { return gps_lat; }
            set { gps_lat = value; }
        }
        private double gps_lon;

        public double Gps_lon
        {
            get { return gps_lon; }
            set { gps_lon = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int licencie;

        public int Licencie
        {
            get { return licencie; }
            set { licencie = value; }
        }

        private List<Trou> lesTrous;
        
        /*
         * Un constructeur VIDE
         * */
        public Club()
        {
            this.lesTrous = new List<Trou>();
        }
        /*
         * Un constructeur qui valorise tous les attributs
         * */
        public Club(string c, string n, string r, string cp, string v, double lat, double lon, string t, string m, int l)
        {
            this.code = c;
            this.nom = n;
            this.rue = r;
            this.cp = cp;
            this.ville = v;
            this.gps_lat = lat;
            this.gps_lon = lon;
            this.tel = t;
            this.email = m;
            this.licencie = l;

            this.lesTrous = new List<Trou>();
        }

        public void setLesTrous(List<Trou> liste)
        {
            this.lesTrous = liste;
        }

        public List<Trou> getLesTrous()
        {
            return this.lesTrous;
        }

        public void ajouterTrou(Trou t)
        {
            this.lesTrous.Add(t);
        }

        public string ToString()
        {
            return this.code + " " + this.nom + " " +this.licencie +" licenciés";
        }
    }
}
