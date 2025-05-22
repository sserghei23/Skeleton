using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //public test data
        string OrderID = "14";
        string FullName = "Walt Walker";
        string Password = "password123";
        string Email = "wwalter@gmail.com";
        string DateOfEmployment = DateTime.Now.ToShortDateString();
       


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

        //Validating the properties of the staff class using these test methods below

        //Validation method if there are blank fields (no characters)
        [TestMethod]
        public void ValidMethodOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //OrderID Validation test-methods.
        [TestMethod]
        public void OrderIDExtremeMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "-1"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if OrderID has 0 characters
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = ""; //this test is expected to fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if OrderID has at least 1 character
        [TestMethod]
        public void OrderIDMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "0"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if OrderID has 2 characters
        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "11"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if OrderID has 5 characters
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message   
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "99999"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if OrderID has 6 characters
        [TestMethod]
        public void OrderIDMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "100000"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if OrderID has 7 characters
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "1000000"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if OrderID has 3 characters
        [TestMethod]
        public void OrderIDMid()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "500"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if OrderID has 500 characters
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '9'); //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if OrderID has data that is not in a number format
        [TestMethod]
        public void OrderIDInvalidData()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "This is not a number"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //FullName Validation test-methods.


        //Password Validation test-methods.

        //Test if Password has 0 characters
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = ""; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if Password has at least 1 character
        [TestMethod]
        public void PasswordMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "a"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if Password has 2 characters
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "ab"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if Password has 19 characters
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "walterwhitebreaking"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if Password has 20 characters
        [TestMethod]
        public void PasswordMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "walterwhitebreaking1"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if Password has 21 characters
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "walterwhitebreaking12"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if Password has 100 characters
        [TestMethod]
        public void PasswordExtremeMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "";
            Password = Password.PadRight(100, 'a'); //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //Email Validation test-methods.


        //DateOfEmployment Validation test-methods.

        //Test if DateOfEmployment has minus 100 days
        [TestMethod]
        public void DateOfEmploymentExtremeMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //variable to store test data
            DateTime TestDate;
            //set variable to today's date
            TestDate = DateTime.Now.Date;
            //subtract 100 years from the date
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string
            string DateOfEmployment = TestDate.ToString();
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if DateOfEmployment has minus 5 days
        [TestMethod]
        public void DateOfEmploymentMinLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //variable to store DateTime test data for DateOfEmployment
            DateTime TestDate;
            //set variable to today's date
            TestDate = DateTime.Now.Date;
            //subtract 1 day from the date
            TestDate = TestDate.AddDays(-5);
            //convert the date to a string by casting
            string DateOfEmployment = TestDate.ToString();
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if DateOfEmployment is the same as the current date
        [TestMethod]
        public void DateOfEmploymentMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //variable to store DateTime test data for DateOfEmployment
            DateTime TestDate;
            //set variable to today's date
            TestDate = DateTime.Now.Date;
            //convert the date to a string by casting
            string DateOfEmployment = TestDate.ToString();
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if DateOfEmployment has plus 1 day
        [TestMethod]
        public void DateOfEmploymentMinPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //variable to store DateTime test data for DateOfEmployment
            DateTime TestDate;
            //set variable to today's date
            TestDate = DateTime.Now.Date;
            //add 1 day to the date
            TestDate = TestDate.AddDays(5);
            //convert the date to a string by casting
            string DateOfEmployment = TestDate.ToString();
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if DateOfEmployment has plus 100 years
        [TestMethod]
        public void DateOfEmploymentExtremeMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //variable to store test data
            DateTime TestDate;
            //set variable to today's date
            TestDate = DateTime.Now.Date;
            //add 100 years to the date
            TestDate = TestDate.AddYears(100);
            //convert the date to a string by casting
            string DateOfEmployment = TestDate.ToString();
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if DateOfEmployment has data that is not in a date format
        [TestMethod]
        public void DateOfEmploymentInvalidData()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string DateOfEmployment = "This is not a date"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

