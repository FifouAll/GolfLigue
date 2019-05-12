using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using GolfLibrary.Classes.DAOClasses;

namespace GolfLigueConsole.Classes.DAOClasses
{
    public class DAOClub : DAOBASE;
    {
        //private MySqlConnection conn;
        public DAOClub() : base()
        {
        }

        public void recordAClub(Club c)
        {
            // Utile pour gérer le problème de virgule qui devient point pour Mysql selon les infos de Globalization
            NumberFormatInfo nfi = new CultureInfo("fr-FR", false).NumberFormat;
            nfi.NumberDecimalSeparator = ".";
            // requête insert
            String myInsertQuery = "insert into club VALUES ('" + c.Code + "','" + c.Nom + "','" + c.Rue + "','" + c.Cp + "', '" + c.Ville + "','" + c.Gps_lat.ToString(nfi) + "','" + c.Gps_lon.ToString(nfi) + "','" + c.Tel + "','" + c.Email + "'," + c.Licencie + ")";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public void deleteAClub(Club c)
        {
            String myQuery = "delete from club where code = '" + c.Code + "'";
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public List<Club> getAllClubs()
        {
            List<Club> lesClubsRecuperes = new List<Club>();

            string requete = "select * from club";

            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Club c = new Club();
                c.Code = rdr[0].ToString();
                c.Nom = rdr[1].ToString();
                c.Rue = rdr[2].ToString();
                c.Cp = rdr[3].ToString();
                c.Ville = rdr[4].ToString();
                c.Gps_lat = Convert.ToDouble(rdr[5].ToString());
                c.Gps_lon = Convert.ToDouble(rdr[6].ToString());
                c.Tel = rdr[7].ToString();
                c.Email = rdr[8].ToString();
                c.Licencie = Convert.ToInt16(rdr[9].ToString());

                DAOTrou daot = new DAOTrou();
                c.setLesTrous(daot.getAllTrousFromClub(c));

                lesClubsRecuperes.Add(c);
            }
            rdr.Close();
            return lesClubsRecuperes;
        }

        public Club getAClubById(string id)
        {
            Club c = null;
            string requete = "select * from club where code = '" + id + "'";

            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                c = new Club();
                c.Code = rdr[0].ToString();
                c.Nom = rdr[1].ToString();
                c.Rue = rdr[2].ToString();
                c.Cp = rdr[3].ToString();
                c.Ville = rdr[4].ToString();
                c.Gps_lat = Convert.ToDouble(rdr[5].ToString());
                c.Gps_lon = Convert.ToDouble(rdr[6].ToString());
                c.Tel = rdr[7].ToString();
                c.Email = rdr[8].ToString();
                c.Licencie = Convert.ToInt16(rdr[9].ToString());
            }
            rdr.Close();
            return c;
        }

        public abstract void Insert(Object o)
        {
            Club c = (Object)o;
            // Utile pour gérer le problème de virgule qui devient point pour Mysql selon les infos de Globalization
            NumberFormatInfo nfi = new CultureInfo("fr-FR", false).NumberFormat;
            nfi.NumberDecimalSeparator = ".";
            // requête insert
            String myInsertQuery = "insert into club VALUES ('" + c.Code + "','" + c.Nom + "','" + c.Rue + "','" + c.Cp + "', '" + c.Ville + "','" + c.Gps_lat.ToString(nfi) + "','" + c.Gps_lon.ToString(nfi) + "','" + c.Tel + "','" + c.Email + "'," + c.Licencie + ")";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public abstract void delete(Object o)
        {
            Club c = (Object)o;
            String myQuery = "delete from club where code = '" + c.Code + "'";
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public abstract void update();

        public abstract List<Object> readall()
        {
            Club c = (Object)o;
        List<Club> lesClubsRecuperes = new List<Club>();

        string requete = "select * from club";

        MySqlCommand cmd = new MySqlCommand(requete, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Club c = new Club();
        c.Code = rdr[0].ToString();
        c.Nom = rdr[1].ToString();
        c.Rue = rdr[2].ToString();
        c.Cp = rdr[3].ToString();
        c.Ville = rdr[4].ToString();
        c.Gps_lat = Convert.ToDouble(rdr[5].ToString());
                c.Gps_lon = Convert.ToDouble(rdr[6].ToString());
                c.Tel = rdr[7].ToString();
        c.Email = rdr[8].ToString();
        c.Licencie = Convert.ToInt16(rdr[9].ToString());

                DAOTrou daot = new DAOTrou();
        c.setLesTrous(daot.getAllTrousFromClub(c));

                lesClubsRecuperes.Add(c);
            }
    rdr.Close();
            return lesClubsRecuperes;
        }
    }
}

