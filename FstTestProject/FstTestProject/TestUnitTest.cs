using ConsoleApplicationForTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FstTestProject
{
    
    
    /// <summary>
    ///This is a test class for TestUnitTest and is intended
    ///to contain all TestUnitTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TestUnitTest
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
        [TestMethod()]
        public void CalculateTotalPricesTest()
        {
            TestUnit target = new TestUnit(); // TODO: Initialize to an appropriate value
            double quanity = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.CalculateTotalPrices(quanity);
            Assert.AreEqual(expected, actual);

            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddInteger
        ///</summary>
        [TestMethod()]
        public void AddIntegerTest()
        {
            TestUnit target = new TestUnit(); // TODO: Initialize to an appropriate value
            int num1 = 0; // TODO: Initialize to an appropriate value
            int num2 = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AddInteger(num1, num2);
            Assert.AreEqual(expected, actual);
           
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
