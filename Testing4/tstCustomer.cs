using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {

        //Good Test Data
        //Create some test Data to pass the method
        string FullName = "Vaydang";
        string PhoneNumber = "7727628467";
        string Password = "vm123";
        string Email = "vaydang02@dhdh.com";
        string DateRegistered = DateTime.Now.ToShortDateString();
        string PostCode = "LE4 0BA";

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

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "123";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);

        }

        

        //Creating a Test Class
        [TestMethod]
        public void FindMethodOK()
        //Create an Instance of the Class we want to Create
        {
            clsCustomer AnCustomer = new clsCustomer();
            //Create a Boolean variable to store the results of the Validation
            Boolean Found = false;
            //Create some Test Data to use with the method
            Int32 CustomerId = 1;
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
            Int32 customerId = 1;
            //check the address id property
            Found = AnCustomer.Find(customerId);
            if (AnCustomer.CustomerId != 1)
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
            Int32 CustomerId = 1;
            //Invoke the method
            Found = AnCustomer.Find(CustomerId);
            //Check the Customer ID
            if (AnCustomer.DateRegistered != Convert.ToDateTime("01/04/2025"))
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PostCode != "LE4 0BA")
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
            Int32 CustomerId = 1;
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
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PhoneNumber != "7727628467")  
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
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.FullName != "Vaydang")
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
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "vaydang02@dhdh.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Password != "vm123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        /******************VALID METHOD******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            FullName = FullName.PadRight(500, 'a'); //This should fail
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            PostCode = PostCode.PadRight(100, 'a'); //This should fail
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PasswordMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            Password = Password.PadRight(500, 'a'); //tHIS should fail
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PhoneNumberMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            PhoneNumber = PhoneNumber.PadRight(11, 'a'); //tHIS should fail
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            Email = Email.PadRight(500, 'a'); //tHIS should fail
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            //Create an Instance of the Class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String Variable to store any error message
            String Error = "";
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
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, Password, DateRegistered);
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
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMin()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //test Data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinPlusOne()
        {
            //Create a instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //String c=variable to store any error message
            String Error = "";
            //test Data
            DateTime TestDate;
            //
            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddDays(1);
            //
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            //Create an Instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //
            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            //
            TestDate = TestDate.AddYears(100);
            //
            string DateRegistered = TestDate.ToString();
            //Assign Data to the property
            
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Email, DateRegistered, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        

        [TestMethod]
        public void DateTimeRegisteredInvalidData()
        {
            //Create an Instance of the classs we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //Set the DataRegistered to a non date Value
            String DateRegistered = "this is not a date";
            //Invoke the method
            Error = AnCustomer.Valid(PostCode, FullName, PhoneNumber, Password, Email, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
    }
}



   


