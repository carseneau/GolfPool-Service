using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using OpenQA.Selenium;

namespace GolfPool_Service
{
    class TournamentScraper
    {

        string url;
        Helper helper = new Helper();
        OpenQA.Selenium.Firefox.FirefoxBinary binary;
        OpenQA.Selenium.Firefox.FirefoxProfile profile;
        IWebDriver driver;
        public TournamentScraper()
        {
            binary = new OpenQA.Selenium.Firefox.FirefoxBinary();
            profile = new OpenQA.Selenium.Firefox.FirefoxProfile();
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver(this.binary, this.profile);
        }
        public TournamentScraper(string firefoxPath, string firefoxProfilePath)
        {
            binary = new OpenQA.Selenium.Firefox.FirefoxBinary(firefoxPath);
            profile = new OpenQA.Selenium.Firefox.FirefoxProfile(firefoxProfilePath);
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver(this.binary, this.profile);
        }
        public void setTournamentURL(string tournamentURL)
        {
            url = tournamentURL;
        }
        public DataTable getTournamentResults()
        {
            driver.Navigate().GoToUrl(url);
            int moneyIndex = driver.FindElements(By.ClassName("tourTournTblHead"))[2].FindElements(By.TagName("td")).Count + 4;
            DataTable dt = new DataTable();
            dt.Columns.Add("GolferName", typeof(string));
            dt.Columns.Add("Winnings", typeof(string));
           
              
            foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableData")))
                {
                    dt.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, helper.ReplaceMoneyString(f.FindElements(By.TagName("td"))[moneyIndex - 1].Text));
                }
                foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableDataAlt")))
                {
                    dt.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, helper.ReplaceMoneyString(f.FindElements(By.TagName("td"))[moneyIndex - 1].Text));
                }
                return dt; 
          
        }
        public System.DateTime getTournamentEndDate()
        {
            System.DateTime dt = new DateTime();
            return dt;
        }
        public DataTable getListOfTournaments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TournamentName");
            dt.Columns.Add("TournamentLink");
            driver.Navigate().GoToUrl("http://www.pgatour.com/r/schedule/");
            foreach (IWebElement e in driver.FindElements(By.ClassName("tourSchArrowFront")))
            {
                dt.Rows.Add(e.Text,e.GetAttribute("href") + "results.html");
            }
            return dt;
        }
        private Boolean checkIfTournamentHasBeenPlayed(string tournamentURL)
        {
            return true;
        }
        public void closeDriver()
        {
            try
            {
                driver.Close();
            }
            catch (Exception ex)
            {
            }
        }
      
    }
}
