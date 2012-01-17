using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace GolfPool_Service
{
    class GolfDriver
    {
        OpenQA.Selenium.Firefox.FirefoxBinary binary;
        OpenQA.Selenium.Firefox.FirefoxProfile profile;
        public IWebDriver driver;

        public GolfDriver()
        {
            binary = new OpenQA.Selenium.Firefox.FirefoxBinary();
            profile = new OpenQA.Selenium.Firefox.FirefoxProfile();
        }

        public GolfDriver(string firefoxPath, string firefoxProfilePath)
        {
            binary = new OpenQA.Selenium.Firefox.FirefoxBinary(firefoxPath);
            profile = new OpenQA.Selenium.Firefox.FirefoxProfile(firefoxProfilePath);
        }

        public void createDriver()
        {
            try
            {
                driver = new OpenQA.Selenium.Firefox.FirefoxDriver(this.binary, this.profile);
            }
            catch (Exception ex)
            {
            }
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
