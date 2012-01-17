using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            resultsGridView.Sort(resultsGridView.Columns["Winnings"],
            resultsGridView.Refresh();
            
            ts.closeDriver();
        }


       
    }
}
