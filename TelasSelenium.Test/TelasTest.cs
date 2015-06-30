using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFrontEnd
{
    [TestClass]
    public class TestesSelenium
    {
        private IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://iallyzildo.azurewebsites.net/");
        }

        [TestCleanup]
        public void testCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void Excluir_Aluno()
        {
            driver.FindElement(By.CssSelector("a[href*='/Aluno']")).Click();
            IWebElement Delete = driver.FindElement(By.LinkText("Delete"));
            Delete.SendKeys(Keys.Enter);
            driver.SwitchTo().Alert().Accept();
        }

    }
}
