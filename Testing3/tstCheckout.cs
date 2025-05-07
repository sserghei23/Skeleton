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
            clsCheckout AnCheckout = new clsCheckout();
            //test to see that it exists
            Assert.IsNotNull(AnCheckout);
        }

        [TestMethod]
        public void TotalCartValuePropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the property
            string TestData = "50b";
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
            DateTime TestData = DateTime.Now.Date;
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
        public void WatchIdPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.WatchId = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.WatchId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.CustomerId = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.CustomerId, TestData);
        }


        [TestMethod]
        public void CartIdPropertyOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            Int32 TestData = 1;
            //Assign Data to the proprty
            AnCheckout.CartId = TestData;
            //test to see that it exists
            Assert.AreEqual(AnCheckout.CartId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //test to see that it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCartIdFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            if (AnCheckout.CartId != 21)
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.DateAdded != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCartValueFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.TotalCartValue != "32b")
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCheckedOutFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.CheckedOut != true)
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        public void TestWatchIdFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.WatchId != "30")
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        public void TestCustomerIdFound()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to  record if the data is OK
            Boolean OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 21;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.CustomerId != "32b")
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        public class clsCheckout
        {
            //private data member for the address id property
            private string mTotalCartValue;
            //cartId public property
            public string TotalCartValue
            {
                get
                {
                    return mTotalCartValue;
                }
                set
                {
                    mTotalCartValue = value;
                }
            }


            public Boolean mCheckkedOut; //{ get; private set; }
            //dateadded public property
            public bool CheckedOut
            {
                get
                {
                    return mCheckkedOut;
                }
                set
                {
                    mCheckkedOut = value;
                }
            }

            public Int32 mCustomerId; //{ get; private set; }

            public int mCheckedOut { get; private set; }

            //dateadded public property
            public Int32 CustomerId
            {
                get
                {
                    return mCustomerId;
                }
                set
                {
                    mCustomerId = value;
                }
            }

            public Int32 mWatchId; //{ get; private set; }
            //dateadded public property
            public Int32 WatchId
            {
                get
                {
                    return mWatchId;
                }
                set
                {
                    mWatchId = value;
                }
            }

            public Int32 mCartId; //{ get; private set; }
            //dateadded public property
            public Int32 CartId
            {
                get
                {
                    return mCartId;
                }
                set
                {
                    mCartId = value;
                }
            }

            public DateTime mDateAdded; //{ get; private set; }
            //dateadded public property
            public DateTime DateAdded
            {
                get
                {
                    return mDateAdded;
                }
                set
                {
                    mDateAdded = value;
                }
            }

            

            public bool Find(int cartId)
            {
                mCartId = 21;
                mDateAdded = Convert.ToDateTime("23/12/2022");
                mWatchId = 21;
                mCustomerId = 21;
                mCheckedOut = 21;
                mTotalCartValue = "21b";
                //always return true
                return true;
            }

            
        }
    }
}

