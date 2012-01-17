using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using OpenQA.Selenium;

namespace GolfPool_Service
{
    class TournamentScraper
    {
        Helper helper = new Helper();
        public void loadTournamentPage(IWebDriver d, string tournamentURL)
        {
            try
            {
                d.Navigate().GoToUrl(tournamentURL);
            }
            catch (Exception ex)
            {
               
            }
        }

        public DataTable getTournamentResults(IWebDriver d, int moneyIndex)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("GolferName", typeof(string));
            dt.Columns.Add("Winnings", typeof(string));
           
              
            foreach (IWebElement f in d.FindElements(By.ClassName("tourTableData")))
                {
                    dt.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, helper.ReplaceMoneyString(f.FindElements(By.TagName("td"))[moneyIndex - 1].Text));
                }
                foreach (IWebElement f in d.FindElements(By.ClassName("tourTableDataAlt")))
                {
                    dt.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, helper.ReplaceMoneyString(f.FindElements(By.TagName("td"))[moneyIndex - 1].Text));
                }
                return dt; 
          
        }

        public int getMoneyIndex(IWebDriver d)
        {
               return  d.FindElements(By.ClassName("tourTournTblHead"))[2].FindElements(By.TagName("td")).Count + 4;
        }

        public System.DateTime getTournamentEndDate()
        {
            System.DateTime dt = new DateTime();
            return dt;
        }

        public DataTable getListOfTournaments(IWebDriver d)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TournamentName");
            dt.Columns.Add("TournamentLink");
            d.Navigate().GoToUrl("http://www.pgatour.com/r/schedule/");
            foreach (IWebElement e in d.FindElements(By.ClassName("tourSchArrowFront")))
            {
                dt.Rows.Add(e.Text,e.GetAttribute("href") + "results.html");
            }
            return dt;
        }

      
    }
}
