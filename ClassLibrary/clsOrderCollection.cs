using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we are not going to use this so we can leave it blank
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //contructor for class
        public clsOrderCollection()
        {
            //variable for index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index <RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current method
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Completed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Completed"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //increment the index
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the datbase based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Completed", mThisOrder.Completed);

            //execute the stored procedure
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //updates a record in the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Completed", mThisOrder.Completed);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}