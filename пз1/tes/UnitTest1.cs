using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void if1_Res()
        {
            int a = 100;
            int b = 100;
            int res = 200;

            Test s = new Test();

            int act = s.if1(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void if2_Res()
        {
            int a = 10;
            int b = 2;
            int res = 8;

            Test s = new Test();

            int act = s.if2(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void if3_Res()
        {
            int a = 10;
            int b = 2;
            int res = 8;

            Test s = new Test();

            int act = s.if3(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void if4_Res()
        {
            int a = 8;
            int b = 2;
            int c = 1;
            int res = 9;

            Test s = new Test();

            int act = s.if4(a, b, c);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void if5_Res()
        {
            int a = 4;
            int b = 24;
            int c = 8;
            int res = 20;

            Test s = new Test();

            int act = s.if5(a, b, c);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void if6_Res()
        {
            int a = 8;
            int b = 2;
            int res = 4;

            Test s = new Test();

            int act = s.if6(a, b);


            Assert.AreEqual(res, act);
        }
    }
}
