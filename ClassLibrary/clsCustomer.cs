using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Private Data memeber for the address id property
        private Int32 mCustomerId;

        public Int32 CustomerId
        {

            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //This line of code allows data intot he property
                mCustomerId = value;
            }
        }

        private DateTime mDateRegistered;
        public DateTime DateRegistered
        {
            get
            {
                //this line of code sends data out of the property
                return mDateRegistered;
            }
            set
            {
                //this line of code allows data into the property
                mDateRegistered = value;
            }
        }

        private string mFullName;
        public string FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code sends data out of the property
                mFullName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code sends data out of the property
                mEmail = value;
            }
        }
        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }

            set
            {
                //this line of code sends data out of the property
                mPhoneNumber = value;
            }

        }
        private Boolean mIsActive;
        public bool IsActive
        {
            get
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                //this line of code sends data out of the property
                mIsActive = value;
            }
        }
        private string mPassword;
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code sends data out of the property
                mPassword = value;

            }
        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into the property
                mPostCode = value;
            }
        }

        public bool Find(int customerId)
        {
            //Create an Instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the address Id to search for
            DB.AddParameter("@CustomerId", customerId);
            //Execute the stored procedure
            DB.Execute("Sproc_tblCustomer_FilterByCustomerId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //Copy the data  from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);

                //Always return True
                return true;
            }
            //if no record was foound
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string dateRegistered, string postCode, string phoneNumber, string email, string fullName, string password)
        {
            //Create a String variable to store the error
            String Error = "";
            DateTime DateTemp;
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + " The Postcode may not be Blank : ";
            }
            //if the PostCode is greater than 6 characters
            if (postCode.Length > 10)
            {
                //Return any Error messages
                Error = Error + "The Postcode must be less than 8 Charchters ; ";
            }

            //Copy the DateRegistered Value to the DateTemp Variable
            DateTemp = Convert.ToDateTime(DateRegistered);
            if (DateTemp < DateTime.Now.Date)
            {
                //Record the error
                Error = Error + " The Date cannot be in the past : ";
            }
            //Check to see if the date is Greater than Today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //Record the error
                Error = Error + "The Date cannot be in the Future: ";
            }

            if (fullName.Length == 0)
            {
                //record the error
                Error = Error + " The Full Name may not be Blank : ";
            }
            //if the PostCode is greater than 20 characters
            if (fullName.Length > 20)
            {
                //Return any Error messages
                Error = Error + "The The Full Name must be less than 8 Charchters ; ";
            }

            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + " The Postcode may not be Blank : ";
            }
            //if the PostCode is greater than 10 characters
            if (postCode.Length > 10)
            {
                //Return any Error messages
                Error = Error + "The Postcode must be less than 8 Charchters ; ";
            }
            if (email.Length == 0)
            {
                //record the error
                Error = Error + " The Email may not be Blank : ";
            }
            //if the PostCode is greater than 500 characters
            if (email.Length > 50)
            {
                //Return any Error messages
                Error = Error + "The Email must be less than 50 Charchters ; ";
            }
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + " The Phone Number may not be Blank : ";
            }
            //if the PostCode is greater than 500 characters
            if (phoneNumber.Length > 10)
            {
                //Return any Error messages
                Error = Error + "The Phone Number must be less than 10 Charchters ; ";
            }

            if (password.Length == 0)
            {
                //record the error
                Error = Error + " The Password may not be Blank : ";
            }
            //if the PostCode is greater than 500 characters
            if (password.Length > 20)
            {
                //Return any Error messages
                Error = Error + "The Password must be less than 50 Charchters ; ";
            }
            //return any error messages
            return Error;
        }
    }

}