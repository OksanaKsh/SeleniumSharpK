using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkKatric
{
    public class Tests:DriverHelper
    {
   
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Setup");
            ChromeOptions options = new ChromeOptions();
            
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
           // Driver.Navigate().GoToUrl("https://executeautomation.com");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            //Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            // Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            var customControl = new CustomControl();
            customControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            System.Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}