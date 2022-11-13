using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemoqaWebPage
{


    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
          
        }

        [SetUp]
        public void Podesavanja()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();
        }

        [Test]
        
        public void Test()
        {
            IWebElement name = driver.FindElement(By.Id("firstName"));
            name.SendKeys("Milos");

            IWebElement LastName = driver.FindElement(By.Id("lastName"));
            LastName.SendKeys("Stankovic");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("milosstankovic6690@gmail.com");

            IWebElement currentAdress = driver.FindElement(By.Id("currentAddress"));
            currentAdress.SendKeys("Spasenoviceva");
        }

        [TearDown]

        public void ZatvaranjeStranice()
        { 
            driver.Close();
        }
    }
}
