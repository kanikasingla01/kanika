using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    [TestFixture]
    public class LinkedinTests
    {
       static IWebDriver driver;
        PageActions pageActions = new PageActions();
        Validations validations = new Validations();

        public String email = "testaccount@gmail.com"; // Replace with valid registered email on linkedin
         public String password = "pass"; // Replace with valid password used when registering
         public String username = "JohnWack"; // Replace with valid username used when registering
         public String fullName = "John Wack";
         public String locality = "Macedonia";
         public String linkedinURL = "https://www.linkedin.com/";

         [SetUp]
         public void SetUp()
         {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);    //ImplicitWait(TimeSpan.FromSeconds(30));
        }
            [Test]
         public void SmokeTest()
         {
            pageActions.navigateToLinkedin(driver, linkedinURL);
            pageActions.Login(driver, email, password);
            pageActions.navigateThroughMenu(driver, PageObjects.ProfileLinkMenu, PageObjects.editProfileLink);
            validations.validateElementIsPresent(driver, PageObjects.addPhotoElement);
            validations.validateTextInElement(driver, PageObjects.fullNameElement, fullName);
            validations.validateTextInElement(driver, PageObjects.localityElement, locality);
            pageActions.Logout(driver);
        }

         [Test]
         [Ignore("Ignore a test")]
        public void RegressionTest()
         {

         }

         [TearDown]
         public void TearDown()
         {
            driver.Quit();
        } 
}
}
