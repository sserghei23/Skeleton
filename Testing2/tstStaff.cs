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
            AStaff.DateOfEmployment = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AStaff.DateOfEmployment, TestData);
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

        //placeholder find method
        [TestMethod]
        public void FindMethodOK()
        { 
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        //find test methods for the attributes of the staff class

        [TestMethod]
        public void TestStaffIDFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffID != 4)
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the OrderID property
            if (AStaff.OrderID != 14)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the FullName property
            if (AStaff.FullName != "Walt Walker")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the Password property
            if (AStaff.Password != "password123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the Email property
            if (AStaff.Email != "wwalker@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfEmploymentFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the DateOfEmployment property
            if (AStaff.DateOfEmployment != Convert.ToDateTime("01/01/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsWorkingFound()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the result of validation
            Boolean Found = false;
            //create variable to record if the data is OK
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the IsWorking property
            if (AStaff.IsWorking != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

