using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    
    [TestClass]
    public class tstCheckoutCollection
    {
        public object TestCheckout { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
           clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            //
            Assert.IsNotNull(AllCheckouts);
        }


        [TestMethod]
        public void CheckoutListOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            List<clsCheckout> TestList = new List<clsCheckout>();
            clsCheckout TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";

            TestList.Add(TestItem); 
            AllCheckouts.CheckoutList = TestList;
            Assert.AreEqual(AllCheckouts.CheckoutList, TestList);
        }


        [TestMethod]
        public void ThisCheckoutPropertyOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            List<clsCheckout> TestList = new List<clsCheckout>();
            clsCheckout TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";
            //
            AllCheckouts.ThisCheckout = TestCheckout;
            Assert.AreEqual(AllCheckouts.ThisCheckout, TestCheckout);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            List<clsCheckout> TestList = new List<clsCheckout>();
            clsCheckout TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";
            //
            TestList.Add(TestItem);
            AllCheckouts.CheckoutList = TestList;
            Assert.AreEqual(AllCheckouts.Count, TestList.Count);
        }

        
    }
}
