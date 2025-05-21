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

        [TestMethod]
        public void AddMethodOk()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalAmount = 100.00m;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            TestItem.Completed = true;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalAmount = 100.00m;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            TestItem.Completed = true;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // modify the test data
            TestItem.CustomerId = 2;
            TestItem.StaffId = 2;
            TestItem.TotalAmount = 200.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Status = "Completed";
            TestItem.Completed = false;
            // set ThisOrder to the modified test data
            AllOrders.ThisOrder = TestItem;
            // update the record
            AllOrders.Update();
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalAmount = 100.00m;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            TestItem.Completed = true;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // delete the record
            AllOrders.Delete();
            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // test that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStatusMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByStatus("");
            //test that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStatusNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a status that doesn't exist
            FilteredOrders.ReportByStatus("xxxx");
            //test that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStatusTestDataFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a status that doesn't exist
            FilteredOrders.ReportByStatus("yyyyyy");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is correct
                if (FilteredOrders.OrderList[0].OrderId != 57)
                {
                    OK = false;
                }
                //check that the second record is correct
                if (FilteredOrders.OrderList[1].OrderId != 58)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
