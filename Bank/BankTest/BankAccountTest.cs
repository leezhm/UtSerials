using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankTest
{
    
    
    /// <summary>
    ///This is a test class for BankAccountTest and is intended
    ///to contain all BankAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BankAccountTest
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
        ///A test for Debet
        ///</summary>
        [TestMethod()]
        public void DebetTest()
        {
            BankAccount target = new BankAccount("Mr Lee", 15000.0); // TODO: Initialize to an appropriate value
            double amount = 4500.0; // TODO: Initialize to an appropriate value
            target.Debet(amount);
            
            Assert.AreEqual(System.Convert.ToDouble(10500.0), target.TotalBalance, 0.05); 
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Credit
        ///</summary>
        [TestMethod()]
        public void CreditTest()
        {
            BankAccount target = new BankAccount("Mr Lee", 15000.0); // TODO: Initialize to an appropriate value
            double amount = 12000.0; // TODO: Initialize to an appropriate value
            target.Credit(amount);

            Assert.AreEqual(27000.0, target.TotalBalance, 0.05);
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FreezeAccount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void FreezeAccountTest()
        {
            // TODO: Initialize to an appropriate value
            BankAccount_Accessor target = new BankAccount_Accessor("Mr Lee", 15000.0); 
            
            // Call FreezeAccount to set isFrozen as true
            target.FreezeAccount();

            bool creditAccount = false; // False means account could be credited: Fail test. 
            
            // Try to credit account
            try
            {
                target.Credit(1.00);
            }
            catch (System.Exception)
            {
                // Threw exception. FreezeAccount worked correctly: Pass test. 
                creditAccount = true;
            }

            // Assert fails if 'creditAccount' condition is false. Fail test.
            Assert.IsTrue(creditAccount, "Was able to credit account.");
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UnfreezeAccount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void UnfreezeAccountTest()
        {
            // TODO: Initialize to an appropriate value
            BankAccount_Accessor target = new BankAccount_Accessor("Mr Lee", 15000.0);
            
            target.UnfreezeAccount();

            bool creditAccount = true; // False means account could be credited: Fail test. 

            // Try to credit account
            try
            {
                target.Credit(1.00);
            }
            catch (System.Exception)
            {
                // Threw exception. FreezeAccount worked correctly: Pass test. 
                creditAccount = false;
            }

            // Assert fails if 'creditAccount' condition is false. Fail test.
            Assert.IsTrue(creditAccount, "Was able to credit account.");
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
