using System;
using System.Data;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCheckout
    {
        //create some test data      
        string DateAdded = DateTime.Now.ToShortDateString();
        string TotalCartValue = "bbbb";



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
            Int32 CartId = 6;
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
            Int32 CartId = 6;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            if (AnCheckout.CartId != 6)
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
            Int32 CartId = 6;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.DateAdded != Convert.ToDateTime("20/05/2025"))
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
            Int32 CartId = 6;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.TotalCartValue != "bbbb")
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
            bool Found = false;
            //Create a Boolean variable to  record if the data is OK
            bool OK = true;
            //Create test data to assign to the proprty
            Int32 CartId = 6;
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
            Int32 CartId = 6;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.WatchId != 4)
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
            Int32 CartId = 4;
            //Assign Data to the proprty
            Found = AnCheckout.Find(CartId);
            //check the date added property
            if (AnCheckout.CustomerId != 3)
            {
                OK = false;
            }
            //test to see that it exists
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void ValidMethodOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";

            string DateAdded = "";          
            string TotalCartValue = "500";
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreEqual(Error, "The date was not valid");
        }

        [TestMethod]
        public void TotalCartValueMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCartValueMin()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "b";
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, " ");
        }

        [TestMethod]
        public void TotalCartValueMinPlusOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "bb";
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, " ");
        }

        [TestMethod]
        public void TotalCartValueMaxLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            TotalCartValue = TotalCartValue.PadRight(49, 'b');
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCartValueMaxPlusOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            TotalCartValue = TotalCartValue.PadRight(51, 'b');
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TotalCartValueMax()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            TotalCartValue = TotalCartValue.PadRight(50, 'b');
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TotalCartValueMid()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            TotalCartValue = TotalCartValue.PadRight(25, 'b');
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCartValueExtremeMax()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string TotalCartValue = "";
            //
            TotalCartValue = TotalCartValue.PadRight(500, 'a');// this should fail
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddYears(-100);
            //
            string DateAdded = TestDate.ToString();
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddDays(-1);
            //
            string DateAdded = TestDate.ToString();
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            string DateAdded = TestDate.ToString();
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, " ");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddDays(1);
            //
            string DateAdded = TestDate.ToString();
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddYears(100);
            //
            string DateAdded = TestDate.ToString();
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCheckout AnCheckout = new clsCheckout();
            //Create test data to assign to the proprty
            String Error = "";
            //test data
            string DateAdded = "this is not a date!";
            //Assign Data to the proprty
            Error = AnCheckout.Valid(DateAdded, TotalCartValue);
            //test to see that it exists
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByTotalCartValue()
        {
            clsCheckout AnCheckout = new clsCheckout();
            DataTable dT = AnCheckout.StatisticsGroupedByTotalCartValue();
            int noOfRecord = 10;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }


        [TestMethod]
        public void StatStatisticsGroupedByDateAdded()
        {
            clsCheckout AnCheckout = new clsCheckout();
            DataTable dT = AnCheckout.StatisticsGroupedByDateAdded();
            int noOfRecord = 9;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}





































































































































































































































































































