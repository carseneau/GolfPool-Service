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
        
        public DbHelper()
        {
            conn = new SqlConnection("Server=12a5e980-74a4-4c94-a480-9fd70124ef10.sqlserver.sequelizer.com;Database=db12a5e98074a44c94a4809fd70124ef10;User ID=dsscpeteldbsyyzj;Password=4SXf82Dtu5m6YCGKykANoz4SuZqo53EBjr2rLHdpnwTQ7Wt8HztVDphBWeThKpxA;");
        }

        public void createDBSchema()
        {
            StreamReader sr = new StreamReader("CreateDatabase.sql");
            cmd = new SqlCommand(sr.ReadToEnd());
            sr.Close();
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int saveEntrant(string entrantname)
        {
            {
                cmd = new SqlCommand("addentrant", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@entrantid", 0)).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@entrantname", entrantname));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                int id;
                int.TryParse(cmd.Parameters["@entrantid"].Value.ToString(), out id);
                
                return id;


            }
        }
        public void saveTournamentResults()
        {
            cmd = new SqlCommand("addwinnings", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("winningsid",0)).Direction = System.Data.ParameterDirection.Output;
      
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
        public int saveGolfer(string golfername)
        {
            cmd = new SqlCommand("addgolfer", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@golferid", 0)).Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@golfername", golfername));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            int id;
            int.TryParse(cmd.Parameters["@golferid"].Value.ToString(), out id);
            return id;
            
        }
        public int savePicks(string entrantname, string golfername)
        {
            cmd = new SqlCommand("addpick", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pickid", 0)).Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@entrantname", entrantname));
            cmd.Parameters.Add(new SqlParameter("@golfername", golfername));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            int id;
            int.TryParse(cmd.Parameters["@pickid"].Value.ToString(), out id);
            return id;
        }

    }
}
