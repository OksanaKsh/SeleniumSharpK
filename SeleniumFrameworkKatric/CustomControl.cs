
using OpenQA.Selenium;

namespace SeleniumFrameworkKatric
{
    public  class CustomControl:DriverHelper
    {
       //IWebDriver Driver;
        public  void ComboBox(string controlName, string value)
        {

            var combobox = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            combobox.Clear();
            combobox.SendKeys(value);
        }
    }
}
