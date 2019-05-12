using GolfLigueConsole.Classes.DAOClasses;
using GolfLigueConsole.Classes.TechnicalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLigueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ApplicationData.chargerLesClubs();
            ApplicationData.afficherLesClubs();

            Console.WriteLine(ApplicationData.chargerUnClub("C0001").ToString());

            /*

            Club c1 = new Club("C0001", "SLAM golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubslam@sio.fr", 14);
            Club c2 = new Club("C0002", "SISR golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubsisr@sio.fr", 12);
            Club c3 = new Club("C0003", "SIO1 golf Club", "rue de la prairie", "55000", "BAR LE DUC", double.Parse("48,758224"), double.Parse("5,115337"), "0329845151", "siogolfclubsio1@sio.fr", 33);

            List<Club> lesClubs = new List<Club>();

            lesClubs.Add(c1);
            lesClubs.Add(c2);
            lesClubs.Add(c3);

            Console.WriteLine("Avant le tri :");
            foreach (Club unC in lesClubs)
            {
                Console.WriteLine(unC.ToString());
            }

            GolfComparator cmp = new GolfComparator();
            lesClubs.Sort(cmp);

            Console.WriteLine("Après le tri :");
            foreach (Club unC in lesClubs)
            {
                Console.WriteLine(unC.ToString());
            }

            
            List<Int16> lesEntiers = new List<Int16>();
            lesEntiers.Add(10);
            lesEntiers.Add(2);
            lesEntiers.Add(34);
            
            Console.WriteLine("Avant le tri :");
            foreach (int un in lesEntiers)
            {
                Console.WriteLine(un);
            }

            lesEntiers.Sort();

            Console.WriteLine("Après le tri");
            foreach (int un in lesEntiers)
            {
                Console.WriteLine(un);
            }
             * */
            Console.ReadKey(true);
        }
    }
}
