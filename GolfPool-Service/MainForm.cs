using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GolfPool_Service
{
    public partial class MainForm : Form
    {

        DataTable listDS;
        public MainForm()
        {

            InitializeComponent();

        }

        private void btnGetTournamentList_Click(object sender, EventArgs e)
        {

            TournamentScraper ts = new TournamentScraper();
            listDS = ts.getListOfTournaments();
            comboBox1.DataSource = listDS;
            comboBox1.DisplayMember = "TournamentName";
            comboBox1.Refresh();
            ts.closeDriver();
        }

        private void errorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tournamentScrapingErrorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnScrapeTournament_Click(object sender, EventArgs e)
        {
            TournamentScraper ts = new TournamentScraper();
            ts.setTournamentURL((string)((DataRowView)comboBox1.SelectedItem).Row["TournamentLink"]);
            resultsGridView.DataSource = ts.getTournamentResults();

            resultsGridView.Refresh();

            ts.closeDriver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TournamentScraper ts = new TournamentScraper();
            ts.InitialGolferAddToDB();
            ts.closeDriver();
        }

        private void resultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TournamentScraper ts = new TournamentScraper();
            ts.InitialEntrantsAddToDB();
            ts.closeDriver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbHelper dbh = new DbHelper();
            PicksDB pdb = new PicksDB();
            DataTable dt = pdb.getPicks();
           
            foreach (DataRow r in dt.Rows)
            {
                if (dbh.savePicks(r["Entrant"].ToString(), r["Golfer"].ToString()) == 0)
                {
                    MessageBox.Show("Error Entering " + r["Entrant"].ToString() + "   " + r["Golfer"].ToString());
                }

            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbHelper dbh = new DbHelper();
       //     dbh.saveTournamentResults(resultsGridView.DataSource);

        }

    }
}