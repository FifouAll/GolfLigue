using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolfLigueConsole.Classes.DAOClasses;
using GolfLigueConsole.Classes.TechnicalClasses;
using GolfLigueConsole;
using GolfLibrary.Classes.DAOClasses;

namespace GolfForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplicationData.chargerLesClubs();
            updateListe();
        }

        private void updateListe()
        {
            lv_clubs.Clear();
            foreach (Club c in ApplicationData.lesClubs)
            {
                lv_clubs.Items.Add(c.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Club c = new Club(tb_code.Text, tb_nom.Text, tb_rue.Text, tb_cp.Text, tb_ville.Text, Convert.ToDouble(tb_lat.Text), Convert.ToDouble(tb_lon.Text), tb_tel.Text, tb_courriel.Text, Convert.ToInt16(tb_effectifs.Text));
            DAOClub dao = new DAOClub();
            dao.recordAClub(c);
            ApplicationData.lesClubs.Add(c);
        }

        private void lv_clubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_clubs.SelectedIndices.Count > 0)
            {
                Club leClub = ApplicationData.lesClubs.ElementAt(lv_clubs.SelectedIndices[0]);
                tb_code.Text = leClub.Code;
                tb_nom.Text = leClub.Nom;
                tb_rue.Text = leClub.Rue;
                tb_cp.Text = leClub.Cp;
                tb_ville.Text = leClub.Ville;
                tb_courriel.Text = leClub.Email;
                tb_tel.Text = leClub.Tel;
                tb_lat.Text = leClub.Gps_lat.ToString();
                tb_lon.Text = leClub.Gps_lon.ToString();

                ApplicationData.actuel = leClub;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (ApplicationData.actuel != null)
                {
                    lb_clubactuel.Text = "Club actuel : " + ApplicationData.actuel.ToString();
                    updateListeTrous();
                }
                else
                {
                    MessageBox.Show("Vous devez sélectionner un club dans la liste pour accéder à cet onglet !");
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void updateListeTrous()
        {
            lv_lestrous.Clear();
            foreach (Trou t in ApplicationData.actuel.getLesTrous())
            {
                lv_lestrous.Items.Add(t.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Trou t = new Trou(Convert.ToInt16(tb_numero.Text), Convert.ToInt16(tb_distance.Text), Convert.ToInt16(tb_par.Text));
            ApplicationData.actuel.ajouterTrou(t);
            DAOTrou dao = new DAOTrou();
            dao.recordATrou(t);
        }

        private void lv_lestrous_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
