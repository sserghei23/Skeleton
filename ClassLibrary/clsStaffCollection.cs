using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private variables for the staff collection
        List<clsStaff> mStaffList = new List<clsStaff>();
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
        public clsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current method
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
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