using DataDrivenTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataDrivenTestProject
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CalculateTotalPrices
        ///</summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    "|DataDirectory|\\testData.csv", "testData#csv", DataAccessMethod.Sequential), 
                    DeploymentItem("DataDrivenTestProject\\testData.csv"), TestMethod()]
        public void CalculateTotalPricesTest()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            //double quantity = 0F; // TODO: Initialize to an appropriate value
            double quantity = Convert.ToDouble(this.testContextInstance.DataRow["Quantity"]);

            //double prices = 0F; // TODO: Initialize to an appropriate value
            double prices = Convert.ToDouble(this.testContextInstance.DataRow["Prices"]);

            //double discountRate = 0F; // TODO: Initialize to an appropriate value
            double discountRate = Convert.ToDouble(this.testContextInstance.DataRow["DiscountRate"]);

            //double expected = 0F; // TODO: Initialize to an appropriate value
            double expected = Convert.ToDouble(this.testContextInstance.DataRow["ExpectedPrices"]);

            double actual;
            actual = target.CalculateTotalPrices(quantity, prices, discountRate);
            Assert.AreEqual(expected, actual);
            
            
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
