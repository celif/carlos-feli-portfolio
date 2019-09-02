using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class SeleniumTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Owner\\Apple\\Desktop\\chromedriver");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://carlos-feli-portfolio-dev-as.azurewebsites.net/";

            // Have Selenium automatically click the links mentioned below to ensure that the
            // the user is taken to the correct section of the page.

            IWebElement homepageLink = driver.FindElement(By.Id("carlos-feliciano"));
            homepageLink.Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://carlos-feli-portfolio-dev-as.azurewebsites.net/#home");

            // Test clicking the about link
            IWebElement aboutLink = driver.FindElement(By.Id("about-link"));
            aboutLink.Click();
            URL = driver.Url;
            Assert.AreEqual(URL, "https://carlos-feli-portfolio-dev-as.azurewebsites.net/#home");

            // Test clicking the skills link
            IWebElement skillsLink = driver.FindElement(By.Id("skills-link"));
            skillsLink.Click();
            URL = driver.Url;
            Assert.AreEqual(URL, "https://carlos-feli-portfolio-dev-as.azurewebsites.net/#skills");

            // Test clicking the projects link
            IWebElement projectsLink = driver.FindElement(By.Id("projects-link"));
            projectsLink.Click();
            URL = driver.Url;
            Assert.AreEqual(URL, "https://carlos-feli-portfolio-dev-as.azurewebsites.net/#projects");

            // Test clicking the experience link
            IWebElement experienceLink = driver.FindElement(By.Id("experience-link"));
            experienceLink.Click();
            URL = driver.Url;
            Assert.AreEqual(URL, "https://carlos-feli-portfolio-dev-as.azurewebsites.net/#experience");
        }

        [Test]
        public void profilePictureTest()
        {
            // Test to see if the profile picture becomes enlarged and centered when clicked
            // and if it returns to normal size when the user anywhere clicks outside the image.

            driver.Url = "https://carlos-feli-portfolio-dev-as.azurewebsites.net/";

            IWebElement profilePicture = driver.FindElement(By.Id("profile-picture"));
            profilePicture.Click();

            bool enlargedImage = driver.FindElement(By.Id("larger-image")).Displayed;

            if (enlargedImage)
            {
                IWebElement myName = driver.FindElement(By.Id("name"));
                myName.Click();
                enlargedImage = driver.FindElement(By.Id("larger-image")).Displayed;
                if(!enlargedImage)
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void socialMediaLinkTest()
        {
            driver.Url = "https://carlos-feli-portfolio-dev-as.azurewebsites.net/";


            // Test the 'mailto:' link
            IWebElement mailtoLink = driver.FindElement(By.Id("mailto"));

            String hrefLink = mailtoLink.GetAttribute("href");

            // Check the href value first
            Assert.AreEqual(hrefLink, "mailto:cfeli031@fiu.edu");

            mailtoLink.Click();

            String URL = driver.Url;

            Assert.AreEqual(URL, "mailto:cfeli031@fiu.edu");

            // Test clicking the Github profile link
            IWebElement githubLink = driver.FindElement(By.Id("github"));

            hrefLink = githubLink.GetAttribute("href");

            Assert.AreEqual(hrefLink, "https://github.com/celif");

            // Go to the Github profile page
            githubLink.Click();

            URL = driver.Url;
            Assert.AreEqual(URL, "https://github.com/celif");

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}