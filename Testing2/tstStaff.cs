using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //test that the instance is not null
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //creates some test data to assign to property
            Int32 TestData = 1;

            //assigns data to the property
            AStaff.StaffID = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //creates some test data to assign to property

            string TestData = "John Doe";
            //assigns data to the property

            AStaff.FullName = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AStaff.FullName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //creates some test data to assign to property
            string TestData = "password123";

            //assigns data to the property
            AStaff.Password = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AStaff.Password, TestData);

        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //creates some test data to assign to property
            string TestData = "jdoe@gmail.com";

            //assigns data to the property
            AStaff.Email = TestData;

            //test to see that two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void DateOfEmploymentPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //creates some test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assigns data to the property
            AStaff.DateAdded = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void IsWorkingPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //creates some test data to assign to property
            Boolean TestData = true;
            //assigns data to the property
            AStaff.IsWorking = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AStaff.IsWorking, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //creates some test data to assign to property
            Int32 TestData = 1;
            //assigns data to the property
            AStaff.OrderID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AStaff.OrderID, TestData);
        }
    }
}

