using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create an Instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Test to see that id exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOk()
        {

            //Create an Instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //In this case the date needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an Item to the list
            //create the iten of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.IsActive = true;
            TestItem.CustomerId = 1;
            TestItem.PhoneNumber = "7727628467";
            TestItem.FullName = "vaydang";
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Email = "vaydang02@dhdh.com";
            TestItem.PostCode = "LE4 0BA";
            TestItem.Password = "vm123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

     

      
    }
}

