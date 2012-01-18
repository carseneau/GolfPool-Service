using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace GolfPool_Service
{
    class DbHelper
    {

        SqlConnection conn;
        SqlCommand cmd;
        
        DbHelper()
        {
            conn = new SqlConnection("Server=12a5e980-74a4-4c94-a480-9fd70124ef10.sqlserver.sequelizer.com;Database=db12a5e98074a44c94a4809fd70124ef10;User ID=dsscpeteldbsyyzj;Password=4SXf82Dtu5m6YCGKykANoz4SuZqo53EBjr2rLHdpnwTQ7Wt8HztVDphBWeThKpxA;");
        }

        public void createDBSchema()
        {
        
            StreamReader sr = new StreamReader("CreateDatabase.sql");
            cmd.CommandText = sr.ReadToEnd();
            sr.Close();
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void saveEntrantPicks()
        {
        
        }

        public void saveTournamentResults()
        {

        }

        public void getSavedTournamentResults()
        {
        }

        public void getPoolStandings()
        {
        }

        public void getEntrantPicks()
        {
        }


    }
}
