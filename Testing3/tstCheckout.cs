using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCheckout
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCheckout AnCheckout  = new clsCheckout ();
            //test to see that it exists
            Assert.IsNotNull(AnCheckout);


        }   

        [TestMethod]
        public void TotalCartValuePropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            string TestData = """500""";
            //Assign Data to the proprty
            AnCheckout.TotalCartValue = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.TotalCartValue, TestData);

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            DateTime TestData = DateTime.Now.Date();
            //Assign Data to the proprty
            AnCheckout.DateAdded = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.DateAdded, TestData);

        }

        [TestMethod]
        public void CheckedOutPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Boolean TestData = true;
            //Assign Data to the proprty
            AnCheckout.CheckedOut = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.CheckedOut, TestData);

        }

        [TestMethod]
        public void WatchidPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.Watchid = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.Watchid, TestData);

        }

        [TestMethod]
        public void CustomeridPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.Customerid = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.Customerid, TestData);

        }


        [TestMethod]
        public void CartidPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.Cartid = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.Cartid, TestData);

        }
    }
}
