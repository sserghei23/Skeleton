using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;


namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //public test data for our various test methods
        string OrderID = "14";
        string FullName = "Walt Walker";
        string Password = "password123";
        string Email = "wwalter@gmail.com";
        string DateOfEmployment = DateTime.Now.ToShortDateString();
       

        //TestMethod to see if there is an instance of staff in the database
        [TestMethod]
        public void InstanceOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //test that the instance is not null
            Assert.IsNotNull(AStaff);
        }

        //TestMethods to see if the attributes of our instance of staff exist.
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

        //Find test methods for the attributes of the staff class

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

        //Test if OrderID has 100 characters
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string OrderID = "";
            OrderID = OrderID.PadRight(100, '9'); //this test should fail
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

        //Test if FullName has 0 characters
        [TestMethod]
        public void FullNameExtremeMin()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = ""; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is not correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if FullName has 1 characters
        [TestMethod]
        public void FullNameMinLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "a"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that is not correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if FullName has at least 3 characters
        [TestMethod]
        public void FullNameMin() 
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "abc"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");

        }

        //Test if FullName has 5 characters
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "abcde"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if FullName has 49 characters
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "";
            FullName = FullName.PadRight(49, 'W'); //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if FullName has 50 characters
        [TestMethod]
        public void FullNameMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "";
            FullName = FullName.PadRight(50, 'W'); //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if FullName has 51 characters
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "";
            FullName = FullName.PadRight(51, 'W'); //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is not correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if FullName has mid 25 characters
        [TestMethod]
        public void FullNameMid()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "Walter White Breaking"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if FullName has 500 characters
        [TestMethod]
        public void FullNameExtremeMax()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string FullName = "";
            FullName = FullName.PadRight(500, 'W'); //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is not correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if FullName has data that contains anything other than letters
        [TestMethod]
        public void FullNameInvalidData()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            string Error = "";
            //creates some test data to use with the method
            string FullName = "47240@~! is not a full name"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is not correct
            Assert.AreNotEqual(Error, "");
        }

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

        //Test if Password has mid 10 characters
        [TestMethod]
        public void PasswordMid()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the error message
            String Error = "";
            //creates some test data to use with the method
            string Password = "password12"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
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

        //Test if Email has 49 characters
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable needed to store the error message
            String Error = "";
            //test data to use with the method
            string Email = "";
            Email = Email.PadRight(39, 'a') + "@gmail.com"; //this value should be okay
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test if Email contains 50 characters
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable needed to store the error message
            String Error = "";
            //test data to use with the method
            string Email = "";
            Email = Email.PadRight(40, 'a') + "@gmail.com";
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");


        }

        //Test if Email has 51 characters
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable needed to store the error message
            String Error = "";
            //test data to use with the method
            string Email = "";
            Email = Email.PadRight(41, 'a') + "@gmail.com"; //this test should fail
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Test if Email has 25 characters
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable needed to store the error message
            String Error = "";
            //test data to use with the method
            string Email = "";
            Email = Email.PadRight(25, 'a') + "@gmail.com";
            //invokes the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable needed to store the error message
            String Error = "";
            //test data to use with the method
            string Email = "";
            Email = Email.PadRight(490, 'a') + "@gmail.com";
            //invoke the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //Test if Email contains invalid data.
        [TestMethod]
        public void EmailInvalidData()
        {
            //create an instance of staff
            clsStaff AStaff = new clsStaff();
            //variable to store error message
            String Error = "";
            //test data to use with the method
            string Email = "this is not an email";
            //invoke the method
            Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
            //assert that the result is correct
            Assert.AreNotEqual(Error, "");

        }

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

        //Test if DateOfEmployment has plus 5 days
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

        //Statistics test methods

        [TestMethod]
        public void StatStatisticsGroupedByFullName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method to get the statistics
            DataTable dT = AStaff.StatisticsGroupedByFullName();
            //According to your last executed stored procedure, there should be 15 rows of data
            int noOfRecord = 26;
            //check that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }

        [TestMethod]
        public void StatStatisticsGroupedByDateOfEmployment()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method to get the statistics
            DataTable dT = AStaff.StatisticsGroupedByDateOfEmployment();
            //According to your last executed stored procedure, there should be 15 rows of data
            int noOfRecord = 21;
            //check that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }



    }
}

