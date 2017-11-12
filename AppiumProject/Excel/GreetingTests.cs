using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlutoSolutionsAppium.Excel
{
    [TestClass]
    public class GreetingTests
    {
        private TestContext testContextInstance;


        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("System.Data.Odbc", "Dsn=Excel Files; dbq = D:\\OneDrive\\PlutoSolutionsDevelopment\\PlutoSolutionsAppium\\PlutoSolutionsAppium\\Excel\\DataSource.xlsx;defaultdir = D:\\OneDrive\\PlutoSolutionsDevelopment\\PlutoSolutionsAppium\\PlutoSolutionsAppium\\Excel; driverid = 1046;maxbuffersize = 2048;pagetimeout = 5", "Sheet1$", 
        DataAccessMethod.Sequential),
        DeploymentItem("D:\\OneDrive\\PlutoSolutionsDevelopment\\PlutoSolutionsAppium\\PlutoSolutionsAppium\\Excel\\DataSource.xlsx"), 
            TestMethod()]
        public void GetGreetingTest()
        {
            Greeting target = new Greeting();
            string name = TestContext.DataRow["FirstName"].ToString();
            string expected = "Hello, " + name;
            string actual = target.GetGreeting(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
