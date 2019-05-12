using GolfLigueConsole.Classes.DAOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLigueConsole.Classes.TechnicalClasses
{
    public class ApplicationData
    {
        public static List<Club> lesClubs;

        public static Club actuel;

        public static void createJeuEssai(){
            Club c1 = new Club("C0001", "SLAM golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubslam@sio.fr", 14);
            Club c2 = new Club("C0002", "SISR golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubsisr@sio.fr", 12);
            Club c3 = new Club("C0003", "SIO1 golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubsio1@sio.fr", 33);

            ApplicationData.lesClubs = new List<Club>();
            lesClubs.Add(c1);
            lesClubs.Add(c2);
            lesClubs.Add(c3);
            /*
            DAOClub clubdao = new DAOClub();
            clubdao.recordAClub(c1);
            clubdao.recordAClub(c2);
            clubdao.recordAClub(c3);
             * */
        }

        public static void sortClubs(string critere)
        {
            GolfComparator cmp = new GolfComparator();

            ApplicationData.lesClubs.Sort(cmp);

            foreach (Club c in ApplicationData.lesClubs)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public static void chargerLesClubs()
        {
            DAOClub dao = new DAOClub();
            lesClubs = dao.getAllClubs();
        }

        public static void afficherLesClubs()
        {
            foreach (Club c in ApplicationData.lesClubs)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public static Club chargerUnClub(string c)
        {
            DAOClub dao = new DAOClub();
            return(dao.getAClubById(c)); 
        }
    }
}
