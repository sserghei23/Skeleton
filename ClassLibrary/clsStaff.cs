using System;
using System.Data;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data members for each attribute
        private Int32 mStaffID;
        private Int32 mOrderID;
        private string mFullName;
        private string mPassword;
        private string mEmail;
        private DateTime mDateOfEmployment;
        private bool mIsWorking;

        //public properties for each attribute test method
        //StaffID public property
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        //OrderID public property
        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        //FullName public property
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }
        //Password public property
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        //Email public property
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        //DateOfEmployment public property
        public DateTime DateOfEmployment
        {
            get
            {
                return mDateOfEmployment;
            }
            set
            {
                mDateOfEmployment = value;
            }
        }
        //IsWorking public property
        public bool IsWorking
        {
            get
            {
                return mIsWorking;
            }
            set
            {
                mIsWorking = value;
            }
        }

        public bool Find(int StaffID)
        {
            //creates data connection to the SQL database
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for by your stored procedure
            DB.AddParameter("@StaffId", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfEmployment"]);
                mIsWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["IsWorking"]);
                //return everything as true to indicate that the record was found
                return true;
            }
            //if no record was found
            else
            {
                //will return false to indicate that the record was not found
                return false;
            }

        }

        public string Valid(string orderID, string fullName, string password, string email, string dateOfEmployment)
        {
            //create a string variable to store the error
            string Error = "";
            //temporary variable to store the date
            int OrderIDTemp;
            DateTime DateTemp;

            //Validating the OrderID field
            try
            {
                //will convert the orderID argument into the Int32 variable
                OrderIDTemp = Convert.ToInt32(orderID);
                //if the orderID is less than 0
                if (OrderIDTemp < 0)
                {
                    //record the error
                    Error = Error + "The Order ID must be greater than 0 : ";
                }

                //if the orderID is blank
                if (orderID.Length == 0)
                {
                    //record the error
                    Error = Error + "The Order ID may not be blank : ";
                }

                //if orderID is greater than 6 characters
                if (OrderIDTemp > 999999)
                {
                    //record the error
                    Error = Error + "The Order ID must be less than 6 characters : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Order ID only accepts integers : ";
            }

            //Validating the FullName field

            //if fullName is blank
            if (fullName.Length == 0)
            {
                //record the error
                Error = Error + "The Full Name may not be blank : ";
            }

            //if fullName is less than 3 characters
            if (fullName.Length < 3)
            {
                //record the error
                Error = Error + "The Full Name must be at least 3 characters : ";
            }

            //if fullName is greater than 50 characters
            if (fullName.Length > 50)
            {
                //record the error
                Error = Error + "The Full Name must not exceed 50 characters : ";
            }

            //statement checks whether fullName contains only letters (lowercase or uppercase) and blankspaces.
            //Regex will accept anything specified within the square brackets.
            if (!Regex.IsMatch(fullName, @"^[a-zA-Z ]+$"))
            {
                //record the error
                Error = Error + "The Full Name can only contain letters and blankspaces : ";
            }

            //Validating the Password field

            //if password is blank
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The Password may not be blank : ";
            }

            //if password is greater than 20 characters
            if (password.Length > 20)
            {
                //record the error
                Error = Error + "The Password must not exceed 20 characters : ";
            }

            //Validating the Email field

            //if email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }

            if (email.Length > 50)
            {

                //record the error
                Error = Error + "The email must not exceed 50 characters : ";
            }

            //Regex validates whether the data inputted into the string contains an email address with correct syntax
            //RegexOptions.IgnoreCase is necessary as email are not case sensitive.
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase))
            {
                //record the error
                Error = Error + "The email must contain the @ symbol, domain name, dot and top-level domain (eg: com) : ";
            }

            //Validating the DateOfEmployment field
            DateTime DateComp = DateTime.Now.Date;
            DateTime DateComp2 = Convert.ToDateTime("02/01/2020");

            try
            {
                //will convert the dateOfEmployment argument into the DateTime variable
                DateTemp = Convert.ToDateTime(dateOfEmployment);

                //if the date is less than 02/01/2020
                if (DateTemp < DateComp2)
                {
                    Error = Error + "The Date of Employment cannot be set before 02/01/2020";
                }
                //if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    Error = Error + "The Date Of Employment cannot be set in the future";
                }
            }
            catch
            {
                Error = Error + "The date set was not valid";
            }

            //return invalid data
            return Error;
        }

        // Statistics grouped by FullName method
        public DataTable StatisticsGroupedByFullName()
        {
            //creates a data connection to the SQL database
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByFullName");
            //return the data table containing the statistics
            return DB.DataTable;
        }

        // Statistics grouped by DateOfEmployment method
        public DataTable StatisticsGroupedByDateOfEmployment()
        {
            //creates a data connection to the SQL database
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupDateOfEmployment");
            //return the data table containing the statistics
            return DB.DataTable;
        }





    }
}