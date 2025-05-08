using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
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
    }
}
