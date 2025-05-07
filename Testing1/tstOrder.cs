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
            anOrder.Active = testData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.Active, testData);
        }
    }
}
