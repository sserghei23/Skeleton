using System;
using System.Data;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to use with the method
        string CustomerId = "1";
        string StaffId = "1";
        string Status = "Delivered";
        string TotalAmount = "69.99";
        string OrderDate = DateTime.Now.Date.ToShortDateString();


        //Testing Testing Testing...
        [TestMethod]
        public void InstanceOk()
        {
            //Create and instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //Test to see that it exists
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anOrder.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.StaffId, TestData);
        }                         

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Delievred";
            //assign the data to the property
            anOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.Status, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 69.99m;
            //assign the data to the property
            anOrder.TotalAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            anOrder.OrderDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(anOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CompletedPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            anOrder.Completed = testData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.Completed, testData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result
            Boolean found = false;
            //create some test data to use with the method
            Int32 OrderId = 11;
            //invoke the method
            found = anOrder.Find(OrderId);
            //test to see that the order was found
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            //invoke the method
            found = anOrder.Find(OrderId);
            //check the order id
            if (anOrder.OrderId != 11)
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            //invoke the method
            found = anOrder.Find(OrderId);
            //check the customer id
            if (anOrder.CustomerId != 5)
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            //invoke the method
            found = anOrder.Find(OrderId);
            //check the staff id
            if (anOrder.StaffId != 5)
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            //invoke the method
            found = anOrder.Find(OrderId);
            //check the status
            if (anOrder.Status != "Delivered")
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            found = anOrder.Find(OrderId);
            //check the total amount
            if (anOrder.TotalAmount != 1114.99m)
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            found = anOrder.Find(OrderId);
            //check the order date
            if (anOrder.OrderDate != Convert.ToDateTime("05/05/2025"))
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }


        [TestMethod]
        public void TestCompletedFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean ok = true;
            //create some test data to use with the method
            Int32 OrderId = 11;
            found = anOrder.Find(OrderId);
            //check the completed
            if (anOrder.Completed != true)
            {
                ok = false;
            }
            //test to see the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = ""; //this should trigger an error
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "a"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "aa"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "aaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
        //---------------------------------------------------------------------------------------
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "aaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
            //------------------------------------------------------------------------------------
        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string Status = "";
            Status = Status.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date to a string
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date to a string
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date to a string
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string Error = "";
            //create some test data to use with the method
            string OrderDate = "This is not a date"; //this should trigger an error
            //invoke the method
            Error = anOrder.Valid(CustomerId, StaffId, Status, TotalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store the error
            string error = "";
            // Use a very large negative value
            string totalAmount = "-10.000.000";
            //invoke the method
            error = anOrder.Valid(CustomerId, StaffId, Status, totalAmount, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            string error = "";
            // Use a value just below zero
            string totalAmount = "-0.01";
            error = anOrder.Valid(CustomerId, StaffId, Status, totalAmount, OrderDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            clsOrder anOrder = new clsOrder();
            string error = "";
            // Use zero as the minimum valid value
            string totalAmount = "0.00";
            error = anOrder.Valid(CustomerId, StaffId, Status, totalAmount, OrderDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string error = "";
            // Use a value just above zero
            string totalAmount = "0.01";
            error = anOrder.Valid(CustomerId, StaffId, Status, totalAmount, OrderDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            string error = "";
            // Use a non-numeric string
            string totalAmount = "seven";
            error = anOrder.Valid(CustomerId, StaffId, Status, totalAmount, OrderDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByStatus()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //invoke the method
            DataTable dT = anOrder.StatisticsGroupedByStatus();
            //according to the test data, we should have 16 rows
            int noOfRecord = 15;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByOrderDate()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //invoke the method
            DataTable dT = anOrder.StatisticsGroupedByOrderDate();
            //according to the test data, we should have 7 rows
            int noOfRecord = 12;
            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
