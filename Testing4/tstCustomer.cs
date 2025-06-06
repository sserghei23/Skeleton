using System;
using System.Data;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {

        //Good Test Data
        //Create some test Data to pass the method
        string FullName = "";
        string PhoneNumber = "";
        string Email = "";
        string DateRegistered = DateTime.Now.Date.ToShortDateString();
        string PostCode = "";

        [TestMethod]
        public void InstanceOK()
        {

            /******************INSTANCE OF THE CLASS TEST******************/

            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test that the instance is not null
            Assert.IsNotNull(AnCustomer);

        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //creates an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void DateRegisteredPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnCustomer.DateRegistered = TestData;
            //test to seee that the two values are the same
            Assert.AreEqual(AnCustomer.DateRegistered, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE4 OBA";
            //assign the data to the property
            AnCustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);

        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Vaydang";
            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);

        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            var TestData = "vaydang02@dhdh.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);

        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "7727628467";
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);

        }
        [TestMethod]
        public void IsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.IsActive, TestData);

        }

        //[TestMethod]
        //public void PasswordPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //create some test data to assign to the property
        //    string TestData = "123";
        //    //assign the data to the property
        //    AnCustomer.Password = TestData;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AnCustomer.Password, TestData);

        //}

        

        //Creating a Test Class
        [TestMethod]
        public void FindMethodOK()
        //Create an Instance of the Class we want to Create
        {
            clsCustomer AnCustomer = new clsCustomer();
            //Create a Boolean variable to store the results of the Validation
            Boolean Found = false;
            //Create some Test Data to use with the method
            Int32 CustomerId = 5;
            //Invoke the Method
            Found = AnCustomer.Find(CustomerId);
            //Test to see if the result is True
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 customerId = 5;
            //check the address id property
            Found = AnCustomer.Find(customerId);
            if (AnCustomer.CustomerId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some Test data to use with the method
            Int32 CustomerId = 5;
            //Invoke the method
            Found = AnCustomer.Find(CustomerId);
            //Check the Customer ID
            if (AnCustomer.DateRegistered != Convert.ToDateTime("25/07/2025"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)

            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PostCode != "LE0 2BB")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        

        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the active property
            if (AnCustomer.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PhoneNumber != "7368000112")  
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.FullName != "David")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 5;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "david12@hotmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //[TestMethod]
        //public void TestPasswordFound()
        //{
        //    clsCustomer AnCustomer = new clsCustomer();
        //    Boolean Found = false;
        //    Boolean OK = true;
        //    Int32 CustomerId = 1;
        //    Found = AnCustomer.Find(CustomerId);
        //    if (AnCustomer.Password != "vm123")
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);
        //}

        /******************VALID METHOD******************/
        [TestMethod]
        public void FullNameMinLessOne()  // 1 char = invalid
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = "a"; // 1 character - too short

            // Provide valid values for other parameters or set defaults
            string PostCode = "12345";
            string PhoneNumber = "0123456789";
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreNotEqual("", Error, "FullName of 1 char should produce an error.");
        }

        [TestMethod]
        public void FullNameMin()  // 2 chars = valid
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = "aa"; // minimum valid length

            // Provide valid data for other parameters
            string PostCode = "AB12 3CD";
            string PhoneNumber = "0123456789";
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error, "FullName of 2 chars should be valid.");
        }


        [TestMethod]
        public void FullNameMid()  // 10 chars = valid
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = "aaaaaaaaaa"; // 10 chars

            string PostCode = "12345";
            string PhoneNumber = "0123456789";
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error, "FullName of 10 chars should be valid.");
        }

        [TestMethod]
        public void FullNameMax()  // 20 chars = valid
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = new string('a', 20); // exactly max length

            string PostCode = "12345";
            string PhoneNumber = "0123456789";
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error, "FullName of 20 chars should be valid.");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()  // 21 chars = invalid
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = new string('a', 21); // 1 char too long

            string PostCode = "12345";
            string PhoneNumber = "0123456789";
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreNotEqual("", Error, "FullName longer than 20 chars should produce an error.");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FullName = new string('a', 500); // This should fail

        }
            //[TestMethod]
            //public void PostCodeMin()
            //{
            //    clsCustomer AnCustomer = new clsCustomer();
            //    string Error = "";
            //    string PostCode = "a"; // 1 char
            //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //    Assert.AreEqual(Error, ""); // Expect no error
            //}
            [TestMethod]
        public void PostCodeMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            string Error = "";
            PostCode = PostCode.PadRight(100, 'a'); //This should fail
            //Invoke the method
            Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        //[TestMethod]
        //public void PasswordMin()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "a";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordMinPlusOne()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "aa";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordMaxLessOne()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "aaaaa";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordMax()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "aaaaaa";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordMid()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "aaa";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordMaxPlusOne()
        //{
        //    //Create a instance of the class we want to creat
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String c=variable to store any error message
        //    string Error = "";
        //    //create some test data to pass to the method
        //    string Password = "aaaaaaa";
        //    //invoke the method
        //    Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void PasswordExtremeMax()
        //{
        //    //Create an Instance of the class we want to create
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //String variable to store any error message
        //    string Error = "";
        //    Password = Password.PadRight(500, 'a'); //tHIS should fail
        //    //Invoke the method
        //    Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
        //    //Test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}



        [TestMethod]
        public void PhoneNumberMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";

            // Initialize all required inputs with valid values except PhoneNumber to test
            string PostCode = "AB12 3CD";               // valid postcode
            string FullName = "John Doe";                // valid full name (length > 2, < 20)
            string PhoneNumber = "a";                     // minimum valid phone number length (1 char)
            string Email = "test@example.com";           // valid email
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");  // valid date (today)

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);

            Assert.AreEqual("", Error, "PhoneNumber with 1 character should be valid.");
        }


        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";

            // Valid inputs for other parameters
            string PostCode = "AB12 3CD";
            string FullName = "John Doe";
            string PhoneNumber = "aaaaaaaaaa";  // exactly 10 characters - max valid length
            string Email = "test@example.com";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);

            Assert.AreEqual("", Error, "PhoneNumber of exactly 10 characters should be valid.");
        }


        [TestMethod]
        public void PhoneNumberMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            string Error = "";
            PhoneNumber = PhoneNumber.PadRight(11, 'a'); //tHIS should fail
            //Invoke the method
            Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Email = "a";  // length 1, valid

            // Provide valid values for other parameters
            string PostCode = "AB12CD";
            string FullName = "John Smith";
            string PhoneNumber = "1234567890";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            string Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Email = "aaa";  // length 3, valid

            string PostCode = "AB12CD";
            string FullName = "John Smith";
            string PhoneNumber = "1234567890";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            string Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Email = new string('a', 50);  // max valid length

            string PostCode = "AB12CD";
            string FullName = "John Smith";
            string PhoneNumber = "1234567890";
            string DateRegistered = DateTime.Now.ToString("yyyy-MM-dd");

            string Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Email = new string('a', 51);  // 1 char too long
            string Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Email = new string('a', 500);  // way too long
            string Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            //Create an Instance of the Class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String Variable to store any error message
            string Error = "";
            //Create a Variable to store the test date data
            // we declared the variable Date Time
            DateTime TestDate;

            //Set the Date to todays date
            // Todays Date and Time
            TestDate = DateTime.Now.Date;

            //Change the date to whatever the date is less 100 yaers
            //we set it to today’s date less 100 years using the AddYears method…
            TestDate = TestDate.AddYears(-100);

            //Convert the Data variable to a String Variable
            string DateRegistered = TestDate.ToString();
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            //create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date us less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateRegisteredMin()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();

            // String variable to store any error message
            string Error = "";

            // Valid values for other parameters
            string PostCode = "AB12CD";
            string FullName = "John Smith";
            string PhoneNumber = "1234567890";
            string Email = "test@example.com";

            // Set DateRegistered to today's date (min valid for your logic)
            DateTime TestDate = DateTime.Now.Date;
            string DateRegistered = TestDate.ToString("yyyy-MM-dd");

            // Call the validation method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);

            // Assert that no error was returned
            Assert.AreEqual("", Error, "DateRegistered of today's date should be valid.");
        }

        [TestMethod]
        public void DateRegisteredMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            string Error = "";
            //test Data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddDays(1);
            //
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            string Error = "";
            //
            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddYears(100);
            //
            string DateRegistered = TestDate.ToString();
            //Assign Data to the property
            
            //Invoke the method
            Error = AnCustomer.Valid(FullName, DateRegistered, PhoneNumber, Email, PostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateTimeRegisteredInvalidData()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();

            // String to store any error message
            string Error = "";

            // Provide valid values for all other inputs
            string PostCode = "AB12CD";
            string FullName = "John Smith";
            string PhoneNumber = "1234567890";
            string Email = "test@example.com";

            // Set DateRegistered to invalid (non-date) value
            string DateRegistered = "this is not a date";

            // Call the validation method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered);

            // This time we expect an error, because the date is invalid
            Assert.AreNotEqual("", Error, "Expected error for invalid date input but got none.");
        }

        [TestMethod]
        public void StatStatisticsGroupedByFullName()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //invoke the method
            DataTable dT = AnCustomer.StatisticsGroupedByFullName();
            
            //According to the last executed stored procedure, there should hbe 10 row of data
            int noOfRecord = 9;

            //test to see that the result is correct 
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }

        [TestMethod]
        public void StatStatisticsGroupedByDateRegistered()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //invoke the method
            DataTable dT = AnCustomer.StatisticsGroupedDateRegistered();
            //according to the last executed stored procedure, there should be 10 rows of data
            int noOfRecord = 12;

            //test to see that the result is correct 
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }



    }
}



   


