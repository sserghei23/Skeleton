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
            //set the private data members to the test data value
            mCustomerId = 1;
            mPostCode = "LE4 0BA";
            mDateRegistered = Convert.ToDateTime("01/04/2025");
            mPhoneNumber = "07727628467";
            mPassword = "vm123";
            mEmail = "vaydang02@dhdh.com";
            mIsActive = true;
            mFullName = "Vaydang";
           
            //Always return True
            return true;
        }

        public bool Find(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}