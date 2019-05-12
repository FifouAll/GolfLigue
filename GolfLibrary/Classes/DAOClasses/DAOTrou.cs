using GolfLigueConsole;
using GolfLigueConsole.Classes.TechnicalClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLibrary.Classes.DAOClasses
{
    public class DAOTrou
    {
        private MySqlConnection conn;
        public DAOTrou() : base()
        {

        }

        public void recordATrou(Trou t)
        {
            String myInsertQuery = "insert into trou VALUES (" + t.Numero + "," + t.Distance + "," + t.Par + ",'" + ApplicationData.actuel.Code + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public List<Trou> getAllTrousFromClub(Club c)
        {
            List<Trou> lesTrousRecuperes = new List<Trou>();

            string requete = "select * from trou where code_club = '" + c.Code + "'";

            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Trou t = new Trou();
                t.Numero = Convert.ToInt16(rdr[0].ToString());
                t.Distance = Convert.ToInt16(rdr[1].ToString());
                t.Par = Convert.ToInt16(rdr[2].ToString());

                lesTrousRecuperes.Add(t);
            }
            rdr.Close();
            return lesTrousRecuperes;
        }

        public abstract void Insert(Object o)
        {
            Trou t = (Object)o;
            String myInsertQuery = "insert into trou VALUES (" + t.Numero + "," + t.Distance + "," + t.Par + ",'" + ApplicationData.actuel.Code + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public abstract void delete(Object o)
        {
            Trou c = (Object)o;
            String myQuery = "delete from club where code = '" + t.Numero + "'";
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public abstract void update()
        {
            String myQuery = "delete from club where code = '" + c.Code + "'";
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();
        }

        public abstract List<Object> readall(Object o)
        {
            Trou t = (Object)o;
        List<Trou> lesTrousRecuperes = new List<Trou>();

        string requete = "select * from trou where code_club = '" + t.Numero + "'";

        MySqlCommand cmd = new MySqlCommand(requete, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Trou t = new Trou();
        t.Numero = Convert.ToInt16(rdr[0].ToString());
                t.Distance = Convert.ToInt16(rdr[1].ToString());
                t.Par = Convert.ToInt16(rdr[2].ToString());

                lesTrousRecuperes.Add(t);
            }
    rdr.Close();
            return lesTrousRecuperes;
        }
    }
}
