using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // test that it exists
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOk()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            //the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalAmount = 100.00m;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            TestItem.Completed = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            // set its properties
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.StaffId = 1;
            TestOrder.TotalAmount = 100.00m;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Status = "Pending";
            TestOrder.Completed = true;
            // assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            // test that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();
            //add and item to the list

            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalAmount = 100.00m;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            TestItem.Completed = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        } 
    }
}
