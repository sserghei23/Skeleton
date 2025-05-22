using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of all staff members in the database
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if the collection exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of all staff members in the database
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create a list of objects to assign test data to
            List<clsStaff> TestList = new List<clsStaff>();
            //create a test staff member and add to the list
            clsStaff TestItem = new clsStaff();
            //set the properties of the test staff member
            TestItem.StaffID = 1;
            TestItem.OrderID = 1;
            TestItem.FullName = "John Doe";
            TestItem.Password = "password123";
            TestItem.Email = "jdoe@gmail.com";
            TestItem.DateOfEmployment = Convert.ToDateTime("2023-01-01");
            TestItem.IsWorking = true;
            TestList.Add(TestItem);
            //assign the test list to the AllStaff collection
            AllStaff.StaffList = TestList;
            //test to see if two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of all staff members in the database
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test staff member
            TestStaff.StaffID = 4;
            TestStaff.OrderID = 14;
            TestStaff.FullName = "Will Smith";
            TestStaff.Password = "password123";
            TestStaff.Email = "wsmith@outlook.com";
            TestStaff.DateOfEmployment = Convert.ToDateTime("2022-06-05");
            TestStaff.IsWorking = false;
            //assign the test data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see if we added test staff to the collection and is available
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOKProperty()
        {
            //create an instance of all staff members in the database
            clsStaffCollection AllStaff = new clsStaffCollection();
            //list of objects that are staff members
            List<clsStaff> TestList = new List<clsStaff>();
            //create some test data to assign to the collection
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test staff member
            TestStaff.StaffID = 4;
            TestStaff.OrderID = 14;
            TestStaff.FullName = "Will Smith";
            TestStaff.Password = "password123";
            TestStaff.Email = "wsmith@outlook.com";
            TestStaff.DateOfEmployment = Convert.ToDateTime("2022-06-05");
            TestStaff.IsWorking = false;
            //add the test staff member to the list
            TestList.Add(TestStaff);
            //assign the test list to the AllStaff collection
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of all staff members in the database
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the collection
            clsStaff TestStaff = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test staff member
            TestStaff.StaffID = 40;
            TestStaff.OrderID = 14;
            TestStaff.FullName = "Will Smith";
            TestStaff.Password = "password123";
            TestStaff.Email = "wsmith@outlook.com";
            TestStaff.DateOfEmployment = Convert.ToDateTime("2022-06-05");
            TestStaff.IsWorking = false;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the staff collection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the collection
            clsStaff TestStaff = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test staff member
            TestStaff.OrderID = 15;
            TestStaff.FullName = "Will Smith";
            TestStaff.Password = "password123";
            TestStaff.Email = "wsmith@outlook.com";
            TestStaff.DateOfEmployment = Convert.ToDateTime("2022-06-05");
            TestStaff.IsWorking = false;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.StaffID = PrimaryKey;
            //modify the test record
            TestStaff.OrderID = 15;
            TestStaff.FullName = "Bill Stark";
            TestStaff.Password = "newpassword123";
            TestStaff.Email = "bstark@outlook.com";
            TestStaff.DateOfEmployment = Convert.ToDateTime("2023-01-01");
            TestStaff.IsWorking = true;
            //set the old record to be updated
            AllStaff.ThisStaff = TestStaff;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);


        }
    }
}
