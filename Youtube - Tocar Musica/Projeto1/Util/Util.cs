using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaçãoCSharp.Util
{
    public static class Util
    {
        [SetUp]
        public static IWebDriver IniciarDriver()
        {
            return new ChromeDriver();
        }

        [TearDown]
        public static void FinalizarDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
