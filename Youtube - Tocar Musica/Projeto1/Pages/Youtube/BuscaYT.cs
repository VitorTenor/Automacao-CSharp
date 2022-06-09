using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Pages.Youtube
{
    class BuscaYT
    {
        private IWebDriver driver;

        public BuscaYT(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcessarSiteYT(string urlYT)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlYT);
        }
        private WebDriverWait Esperar()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private IWebElement BucarMusica()
        {
            return driver.FindElement(By.XPath("//input[@id='search']"));
        }

        public void preenchercampobusca()
        {
            Esperar().Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='search']")));
            BucarMusica().SendKeys("Exemplos Mc Hariel");
        }
        private IWebElement ClicoEmBuscar()
        {
            return driver.FindElement(By.XPath("//button[@id='search-icon-legacy'] "));
        }
        public void clicoembuscar()
        {
            ClicoEmBuscar().Click();
        }

        private IWebElement ClicaMusica()
        {
            return driver.FindElement(By.XPath("//a[@title='MC Hariel - Exemplos Feat. MC Neguinho do Kaxeta (GR6 Explode) Faixa 8 - DVD Mundão Girou'] "));
        }
        public void clicomusica()
        {
            Esperar().Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@title='MC Hariel - Exemplos Feat. MC Neguinho do Kaxeta (GR6 Explode) Faixa 8 - DVD Mundão Girou'] ")));
            ClicaMusica().Click();
        }
        private By ProgressoMusica()
        {
            return By.XPath("//div[@class='ytp-progress-list']");
        }
        public Boolean verificamusica()
        {
            if (Esperar().Until(ExpectedConditions.ElementIsVisible(ProgressoMusica())).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



