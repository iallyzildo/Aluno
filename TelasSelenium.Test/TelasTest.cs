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
            driver.SwitchTo().Alert().Dismiss();
        }
        [TestMethod]
        public void TestarMenus()
        {
            driver.FindElement(By.CssSelector("a[href*='/Aluno']")).Click();
            driver.FindElement(By.CssSelector("a[href*='/']")).Click();
            driver.FindElement(By.CssSelector("a[href*='/Home/Contact']")).Click();
            
        }
        [TestMethod]
        public void BuscarAluno()
        {
            driver.FindElement(By.CssSelector("a[href*='/Aluno']")).Click(); 
            IWebElement searchInput = driver.FindElement(By.Id("a"));
            searchInput.SendKeys("ferreira");
            searchInput.SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void AdicionarAluno()
        {
            //Entra na pagina de aluno
            driver.FindElement(By.CssSelector("a[href*='/Aluno']")).Click();
            //Clica no botao novo
            driver.FindElement(By.XPath("//*[@id='Novo']")).Click();
            //preenche o campo nome
            IWebElement Nome = driver.FindElement(By.Id("Nome"));
            Nome.SendKeys("iallyzildo");
            //preenche o campo CPF
            IWebElement CPF = driver.FindElement(By.Id("CPF"));
            CPF.SendKeys("12281028640");
            //preenche o campo nome
            IWebElement Matricula = driver.FindElement(By.Id("Matricula"));
            Matricula.SendKeys("87654321");
            Matricula.SendKeys(Keys.Enter);

            string lista = driver.FindElement(By.Id("Lista")).Text;
            Assert.IsTrue(lista.Contains("iallyzildo"));
        }

    }
}
