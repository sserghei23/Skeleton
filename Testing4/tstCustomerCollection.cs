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
        public void InstanceOK() 
        {
            //Create an Instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Test to see that id exists
            Assert.IsNotNull(AllCustomer);
        }


        //[TestMethod]
        //public void CustomerListOk()
        //{

        //    //Create an Instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    //In this case the date needs to be a list of objects
        //    List<clsCustomer> TestList = new List<clsCustomer>();
        //    //add an Item to the list
        //    //create the iten of test data
        //    clsCustomer TestItem = new clsCustomer();
        //    //set its properties
        //    TestItem.IsActive = true;
        //    TestItem.CustomerId = 1;
        //    TestItem.PhoneNumber = "7727628467";
        //    TestItem.FullName = "vaydang";
        //    TestItem.DateRegistered = DateTime.Now;
        //    TestItem.Email = "vaydang02@dhdh.com";
        //    TestItem.PostCode = "LE4 0BA";
        //    TestItem.Password = "vm123";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllCustomer.CustomerList = TestList;
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.Count, TestList.Count);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsActive = true;
            TestItem.CustomerId = 9;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.PostCode = "LE1 0BA";
            TestItem.Email = "veyd2000@gmail.com";
            TestItem.PhoneNumber = "7727628111";
            TestItem.FullName = "Veyd";
            TestItem.Password = "veyd123";
           
            //Set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomer.Add();
            //Set the primary ket of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //varaible to store the primary Key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsActive = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.FullName = "Abhimanyu";
            TestItem.PostCode = "BH1 0AD";
            TestItem.PhoneNumber = "7499909172";
            TestItem.Email = "Abhimany_2002@hotmail.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //Set the primary ket of the test data
            TestItem.CustomerId = PrimaryKey;
            //Modify the test record
            TestItem.IsActive = false;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.PostCode = "NZ1 34BA";
            TestItem.Email = "Abhimanyu@2002hotmail.com";
            //update the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //Update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //Test to see of This Customer matches the test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an Instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Create the Item of Test Data
            clsCustomer TestItem = new clsCustomer();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its Properties
            TestItem.IsActive = true;
            TestItem.CustomerId = 1;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.FullName = "Delete me";
            TestItem.PostCode = "LE9 0ZY";
            TestItem.Email = "Delete01@hotmail.co.uk";
            TestItem.PhoneNumber = "7466686822";
            TestItem.Password = "delete";
            //Set ThisCustomer to the test Data
            AllCustomer.ThisCustomer= TestItem;
            //Add the record
            PrimaryKey=AllCustomer.Add();
            //Set the Primary key of the test data
            TestItem.CustomerId= PrimaryKey;
            //Find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //Delte the record
            AllCustomer.Delete();
            //Now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //Test to see that the record eas not found
            Assert.IsFalse( Found );

        }
    }
}

