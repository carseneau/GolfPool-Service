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
        ErrorHandling e = new ErrorHandling();
        GolfDriver d;
        Tournament t = new Tournament();
        TournamentScraper ts = new TournamentScraper();
        public MainForm()
        {
            
            InitializeComponent();
            t.setTournamentURL("http://www.pgatour.com/tournaments/r016/results.html");
          ts.loadTournamentPage(t.tournamentURL,ts.getMoneyIndex(d.driver),t.tournamentURL)));
            ts.getTournamentResults(d.driver
        }

        private void btnGetTournamentList_Click(object sender, EventArgs e)
        {
            d = new GolfDriver();
            d.createDriver();
            TournamentScraper ts = new TournamentScraper();
            comboBox1.DataSource = ts.getListOfTournaments(d.driver);
            comboBox1.Refresh();
        }

        private void errorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tournamentScrapingErrorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       
    }
}
