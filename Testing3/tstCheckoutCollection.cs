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
            
            clsCheckout TestCheckout = new clsCheckout();
            
            //set priorities
            TestCheckout.CheckedOut = true;
            TestCheckout.CartId = 1;
            TestCheckout.CustomerId = 1;
            TestCheckout.WatchId = 1;
            TestCheckout.DateAdded = DateTime.Now;
            TestCheckout.TotalCartValue = "500";
            //
            AllCheckouts.ThisCheckout = (clsCheckout)TestCheckout;
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

        [TestMethod]
        public void AddMethodOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            //
            clsCheckout TestItem = new clsCheckout();
            Int32 PrimaryKey = 0;
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";
            //
            AllCheckouts.ThisCheckout = TestItem;
            //
            PrimaryKey = AllCheckouts.Add();
            //
            TestItem.CartId = PrimaryKey;
            //
            AllCheckouts.ThisCheckout.Find(PrimaryKey);
            //
            Assert.AreEqual(AllCheckouts.ThisCheckout, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            //
            clsCheckout TestItem = new clsCheckout();
            Int32 PrimaryKey = 0;
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";
            //
            AllCheckouts.ThisCheckout = TestItem;
            //
            PrimaryKey = AllCheckouts.Add();
            //
            TestItem.CartId = PrimaryKey;
            //
            TestItem.CheckedOut = true;
            TestItem.CartId = 6;
            TestItem.CustomerId = 4;
            TestItem.WatchId = 4;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "bbbb";
            //
            AllCheckouts.ThisCheckout = TestItem;

            AllCheckouts.Update();
            //
            AllCheckouts.ThisCheckout.Find(PrimaryKey);
            //
            Assert.AreEqual(AllCheckouts.ThisCheckout, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            //
            clsCheckout TestItem = new clsCheckout();
            Int32 PrimaryKey = 0;
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.TotalCartValue = "500";
            //
            AllCheckouts.ThisCheckout = TestItem;
            //
            PrimaryKey = (int)AllCheckouts.Add();
            //
            TestItem.CartId = PrimaryKey;
            //
            AllCheckouts.ThisCheckout.Find(PrimaryKey);
            //
            AllCheckouts.Delete();
            //
            Boolean Found = AllCheckouts.ThisCheckout.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTotalCartValueMethodOK()
        {
            clsCheckoutCollection AllCheckouts = new clsCheckoutCollection();
            clsCheckoutCollection FilterCheckouts = new clsCheckoutCollection();
            FilterCheckouts.ReportByTotalCartValue("");
            Assert.AreEqual(AllCheckouts.Count, FilterCheckouts.Count + 2);

        }

        [TestMethod]
        public void ReportByTotalCartValueNoneFound()
        {
            clsCheckoutCollection FilterCheckouts = new clsCheckoutCollection();
            FilterCheckouts.ReportByTotalCartValue("c");
            Assert.AreEqual(0, FilterCheckouts.Count);

        }

        [TestMethod]
        public void ReportByTotalCartValueTestDataFound()
        {
            clsCheckoutCollection FilterCheckouts = new clsCheckoutCollection();
            //
            Boolean OK = true;
            ///
            FilterCheckouts.ReportByTotalCartValue("aaaa");
            //
            if (FilterCheckouts.Count == 2)
            {
                if (FilterCheckouts.CheckoutList[0].CartId != 11)
                {
                    OK = false;
                }
                if (FilterCheckouts.CheckoutList[1].CartId != 12)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //tests to see if its true
            Assert.IsTrue(OK);
        }
    }
}
