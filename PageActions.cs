using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public  class PageActions
    {
        BasicMethods basicMethod = new BasicMethods();
         Validations validations = new Validations();

         public void navigateToLinkedin(IWebDriver driver, String linkedinURL)
         {
         driver.Navigate().GoToUrl(linkedinURL);
         validations.validateScreenByUrl(driver, linkedinURL);
         validations.validateElementIsPresent(driver, PageObjects.forgotPassLink);
         }

        public void Login(IWebDriver driver, String email, String password)
        {
         basicMethod.clickElement(driver, PageObjects.loginEmailInput);
         basicMethod.sendKeys(driver, PageObjects.loginEmailInput, email);
         basicMethod.clickElement(driver, PageObjects.loginPassInput);
         basicMethod.sendKeys(driver, PageObjects.loginPassInput, password);
                    basicMethod.clickElement(driver, PageObjects.loginButton);
         // Wait up to 30s for the user to login and to be redirected to Home screen
         driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
         validations.validateElementIsPresent(driver, PageObjects.newsFeedElement);
         }

         public void navigateThroughMenu(IWebDriver driver, By menu, By submenu)
         {
         Actions builder = new Actions(driver);
         builder.MoveToElement(driver.FindElement(menu)).Perform();
         builder.MoveToElement(driver.FindElement(submenu)).Click().Perform();
         }

        public void Logout(IWebDriver driver)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(PageObjects.navProfilePhoto)
            ).Perform();
            builder.MoveToElement(driver.FindElement(PageObjects.logoutButton)).Click().Perform();
             } 
        }
}
