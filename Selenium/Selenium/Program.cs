using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver chromedriver = new ChromeDriver();
            chromedriver.Manage().Window.Maximize();

            //Register
            chromedriver.Navigate().GoToUrl("http://localhost:3000/signup");
            Thread.Sleep(2000);

            IWebElement name = chromedriver.FindElement(By.Id("username"));
            name.SendKeys("Karnisha");
            Thread.Sleep(2000);
            IWebElement phone = chromedriver.FindElement(By.Id("phone"));
            phone.SendKeys("9872671234");
            Thread.Sleep(2000);
            IWebElement location = chromedriver.FindElement(By.Id("location"));
            location.SendKeys("Madurai");
            Thread.Sleep(2000);

            IWebElement registeremail = chromedriver.FindElement(By.Id("email"));
            registeremail.SendKeys("karnisha@gmail.com");
            Thread.Sleep(2000);

            IWebElement registerpassword = chromedriver.FindElement(By.Id("password"));
            registerpassword.SendKeys("karni123");
            Thread.Sleep(2000);

            IWebElement confirmpassword = chromedriver.FindElement(By.Id("cpassword"));
            confirmpassword.SendKeys("karni123");
            Thread.Sleep(2000);

            IWebElement register = chromedriver.FindElement(By.Id("submitbtn"));
            register.Click();
            Thread.Sleep(2000);

            // Handle alert
            try
            {
                //IAlert alert = chromedriver.SwitchTo().Alert();
                //string alertText = alert.Text;
                //Console.WriteLine("Alert text: " + alertText);
                //alert.Accept(); // To accept the alert (click OK)
                                //alert.Dismiss(); // To dismiss the alert (click Cancel)

                string nextPageUrl = "http://localhost:3000/login";
                chromedriver.Navigate().GoToUrl(nextPageUrl);

            }
            catch (NoAlertPresentException)
            {
                // No alert present, continue with the rest of the code
            }



            //Login
            chromedriver.Navigate().GoToUrl("http://localhost:3000/login");
            Thread.Sleep(2000);

            IWebElement loginemail = chromedriver.FindElement(By.Id("email"));
            loginemail.SendKeys("karnisha@gmail.com");
            Thread.Sleep(2000);

            IWebElement loginpassword = chromedriver.FindElement(By.Id("password"));
            loginpassword.SendKeys("karni123");
            Thread.Sleep(2000);

            IWebElement login = chromedriver.FindElement(By.Id("login"));
            login.Click();
            Thread.Sleep(2000);

            // Handle alert
            try
            {
                //IAlert alert = chromedriver.SwitchTo().Alert();
                //string alertText = alert.Text;
                //Console.WriteLine("Alert text: " + alertText);
                //alert.Accept(); // To accept the alert (click OK)
                                //alert.Dismiss(); // To dismiss the alert (click Cancel)

                string nextPageUrl = "http://localhost:3000/userdash";
                chromedriver.Navigate().GoToUrl(nextPageUrl);

            }
            catch (NoAlertPresentException)
            {
                // No alert present, continue with the rest of the code
            }
        }
    }
}