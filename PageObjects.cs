using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class PageObjects
    {// Login screen objects
    public static By loginEmailInput = By.Id("login-email");
     public static By loginPassInput = By.Id("login-password");
     public static By loginButton = By.Id("login-submit");
     public static By forgotPassLink = By.LinkText("Forgot password?");

     // Home screen objects
     public static By newsFeedElement = By.Id("ozfeed");

     // Profile screen objects
     public static By fullNameElement = By.ClassName("full-name");
     public static By localityElement = By.ClassName("locality");

     // Menu objects
            public static By ProfileLinkMenu = By.XPath(".//*[@id='main-sitenav']/ul/li[2]/a");
     public static By editProfileLink = By.XPath(".//*[@id='profile-subnav']/li[1]/a");
     public static By addPhotoElement = By.ClassName("edit-photo-content");
     public static By navProfilePhoto = By.ClassName("nav-profile-photo");
         public static By logoutButton = By.XPath(".//*[@id='account-subnav']/div/div[2]/ul/li[1]/div/span/span[3]/a");
    }
}
