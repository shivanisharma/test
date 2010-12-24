using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace SampleTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass,ignore]
    public class UnitTest1
    {
        private ISelenium selenium;
        [TestMethod]
        public void TestMethod1()
        {
            selenium = new DefaultSelenium("localhost", 4444, "*iexplore", "http://www.google.com/");
            selenium.Start();

            selenium.Open("/");
            selenium.Type("q", "selenium rc");
            selenium.Click("btnG");
            selenium.WaitForPageToLoad("30000");
            Assert.AreEqual("selenium rc - Google Search", selenium.GetTitle());

            try
            {
                selenium.Stop();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }



        }
        [TestMethod]
        public void TestMethod3()
        {
            string URL = "http://www.abb.com";
            selenium = new DefaultSelenium("localhost", 4444, "*firefox", URL);
            selenium.Start();
            selenium.Open("/");
            Assert.AreEqual("The ABB Group - Automation and Power Technologies", selenium.GetTitle());
            selenium.Type("searchInput", "Robot");
            selenium.Click("search");
            selenium.WaitForPageToLoad("10000");
            Assert.AreEqual("The ABB Group", selenium.GetTitle());
            Assert.AreEqual("Robot", selenium.GetValue("searchInput"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            selenium = new DefaultSelenium("localhost", 4444, "*iexplore", "http://localhost:1987");
            selenium.Start();
            selenium.Open("/WebSite1/");
            selenium.Type("MainContent_TextBox1", "HUM");
            selenium.Click("MainContent_Button1");
            selenium.WaitForPageToLoad("3000770");
            
            //Get the Table Value of Row 1 and Coulumn 2
            object GG = selenium.GetTable("MainContent_GridView1.1.2");
            
            Assert.AreEqual("1", "1");
            try
            {
                selenium.Stop();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }



        }
        [TestMethod]
        public void TestMethod4()
        {
            selenium = new DefaultSelenium("localhost", 4444, "*iexplore", "http://localhost:1987");
            selenium.Start();
            selenium.Open("/WebSite1/");
            selenium.Type("MainContent_TextBox1", "HUM");
            selenium.Click("MainContent_Button1");
            selenium.WaitForPageToLoad("3000770");
            object GG = selenium.GetTable("MainContent_GridView1.1.2");
            Assert.AreEqual("1", "1");   
        }
        [TestMethod]
        public void TestMethod5()
        {
            selenium = new DefaultSelenium("localhost", 4444, "*iexplore", "http://localhost:1987");
            selenium.Start();
            selenium.Open("/WebSite1/");
            selenium.Type("MainContent_TextBox1", "HUM");
            selenium.Click("MainContent_Button1");
            selenium.WaitForPageToLoad("3000770");
            object GG = selenium.GetTable("MainContent_GridView1.1.2");
            Assert.AreEqual("1", "1");
        }
    }
}
