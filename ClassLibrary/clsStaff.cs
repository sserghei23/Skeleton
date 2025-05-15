using System;

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
    }
}