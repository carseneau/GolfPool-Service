using System;
using System.Collections.Generic;
using System.Data;
using OpenQA.Selenium;
namespace GolfPool
{
    public class Tournament
    {
        IWebDriver driver;
        string tournamentPageURL;
        string tournamentBasePageURL;
        int moneyIndexOnPage;
        public DataTable tournamentResultsTable;
        OpenQA.Selenium.Firefox.FirefoxBinary binary;
        OpenQA.Selenium.Firefox.FirefoxProfile profile;
        List<string> tournamentList;

        public Tournament(string tournamentURL,string firefoxPath,string firefoxProfilePath)
        {
            try
            {
                binary = new OpenQA.Selenium.Firefox.FirefoxBinary(firefoxPath);
                profile = new OpenQA.Selenium.Firefox.FirefoxProfile(firefoxProfilePath);
                tournamentResultsTable = new DataTable("tournamentresults");
                tournamentResultsTable.Columns.Add("TournamentEndDate", typeof(string));
                tournamentResultsTable.Columns.Add("TournamentName", typeof(string));
                tournamentResultsTable.Columns.Add("Golfer", typeof(string));
                tournamentResultsTable.Columns.Add("Prize", typeof(string));
                tournamentPageURL = tournamentURL;
            }
            catch (Exception ex)
            {

            }
        }
        public bool loadTournamentPage()
        {
            try
            {
                driver = new OpenQA.Selenium.Firefox.FirefoxDriver(binary, profile);
                driver.Navigate().GoToUrl(tournamentPageURL);
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public bool loadTournamentBasePage()
        {
            try
            {
                driver = new OpenQA.Selenium.Firefox.FirefoxDriver(binary, profile);
                driver.Navigate().GoToUrl(tournamentPageURL);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool setMoneyIndexOnPage()
        {
            try
            {
                moneyIndexOnPage = driver.FindElements(By.ClassName("tourTournTblHead"))[2].FindElements(By.TagName("td")).Count + 4;
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public bool setTournamentResults()
        {
            try
            {
                foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableData")))
                {
                    tournamentResultsTable.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, f.FindElements(By.TagName("td"))[moneyIndexOnPage - 1].Text.Replace("$", "").Replace(",", ""));
                }
                foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableDataAlt")))
                {
                    tournamentResultsTable.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, f.FindElements(By.TagName("td"))[moneyIndexOnPage - 1].Text.Replace("$", "").Replace(",", ""));
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool setTournamentList()
        {
            try
            {
                tournamentList = new List<string>();
                foreach (IWebElement e in driver.FindElements(By.ClassName("tourSchArrowFront")))
                {
                    tournamentList.Add(e.GetAttribute("href") + "results.html");
                }
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }
        public bool setAllTournamentResults()
        {
            try 
            {
                foreach (String t in tournamentList)
                {
                    driver.Navigate().GoToUrl(t);
                    foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableData")))
                    {
                        tournamentResultsTable.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, f.FindElements(By.TagName("td"))[moneyIndexOnPage - 1].Text.Replace("$", "").Replace(",", ""));
                    }
                    foreach (IWebElement f in driver.FindElements(By.ClassName("tourTableDataAlt")))
                    {
                        tournamentResultsTable.Rows.Add(f.FindElements(By.TagName("td"))[0].Text, f.FindElements(By.TagName("td"))[moneyIndexOnPage - 1].Text.Replace("$", "").Replace(",", ""));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool closeFirefoxDriver()
        {
            try
            {
                driver.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}