using System;
using System.Collections.Generic;
using System.Data;
using OpenQA.Selenium;
namespace GolfPool_Service
{
    public class Tournament 
    {
        System.DateTime tournamentEndDate;
        public DataTable tournamentResults;
        public string tournamentURL;
        string tournamentName;
        TournamentScraper ts = new TournamentScraper();
       
        public Tournament()
        {
            try
            {
            
            }
            catch (Exception ex)
            {
             
            }
        }
        public void setTournamentURL(string url)
        {
            try
            {
                tournamentURL = url;
            }
            catch (Exception ex)
            {
            }
        }
    }
}