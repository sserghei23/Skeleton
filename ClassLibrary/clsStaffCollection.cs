using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private variables for the staff collection
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //do nothing
            }
        }
        public clsStaff ThisStaff {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            //establish a connection to the database
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to select all records
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the staff list with the data from the database
            PopulateArray(DB);
            //the above method will populate the mStaffList with the data from the database


            //variable for the index
            //Int32 Index = 0;
            //variable to store the record count
            //Int32 RecordCount = 0;
            //object for data connection
            //clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            //DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            //RecordCount = DB.Count;
            //while there are records to process
            //while (Index < RecordCount)
            //{
            //create a blank staff member
            //clsStaff AStaff = new clsStaff();
            //read in the fields for the current method
            //AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
            //AStaff.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
            //AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
            //AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
            //AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
            //AStaff.DateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
            //AStaff.IsWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsWorking"]);
            //add the record to the private data member
            //mStaffList.Add(AStaff);
            //increment the index
            // Index++;
            //}

        }

        public int Add()
        {
            //this method will add a record to the database containing
            //the properties of the staff member.
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisStaff.OrderID);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@DateOfEmployment", mThisStaff.DateOfEmployment);
            DB.AddParameter("@IsWorking", mThisStaff.IsWorking);
            //execute the stored procedure
            return DB.Execute("sproc_tblStaff_Insert");
        }

        //Unlike the ADD method above, it is essential for the Update record to fetch the primary key
        //so that the correct record is updated.
        public void Update()
        {
            //this method will update an existing record in the database
            //establishes a connection to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffID);
            DB.AddParameter("@OrderId", mThisStaff.OrderID);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@DateOfEmployment", mThisStaff.DateOfEmployment);
            DB.AddParameter("@IsWorking", mThisStaff.IsWorking);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record from the database as pointed to by the ThisStaff property
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFullName(string v)
        {
            //method filters records based on fullName
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", v);
            DB.Execute("sproc_tblStaff_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the staff array list from the database in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.DateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
                AStaff.IsWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsWorking"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //increment the index
                Index++;
            }
        }
    }
}