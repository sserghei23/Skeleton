using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data members for the order id property
        private Int32 mOrderId;
        //order id public property
        public Int32 OrderId
        {
            get
            {
                //sends data out of the property
                return mOrderId;
            }
            set
            {
                //allows data into the property
                mOrderId = value;
            }
        }
        //private data members for the customer id property
        private Int32 mCustomerId;
        //customer id public property
        public Int32 CustomerId
        {
            get
            {
                //sends data out of the property
                return mCustomerId;
            }
            set
            {
                //allows data into the property
                mCustomerId = value;
            }
        }
        //private data members for the staff id property
        private Int32 mStaffId;
        //staff id public property
        public Int32 StaffId
        {
            get
            {
                //sends data out of the property
                return mStaffId;
            }
            set
            {
                //allows data into the property
                mStaffId = value;
            }
        }

        //private data members for the status property
        private string mStatus;
        //status public property
        public string Status
        {
            get
            {
                //sends data out of the property
                return mStatus;
            }
            set
            {
                //allows data into the property
                mStatus = value;
            }
        }
        //private data members for the total amount property
        private decimal mTotalAmount;
        //total amount public property
        public decimal TotalAmount
        {
            get
            {
                //sends data out of the property
                return mTotalAmount ;
            }
            set
            {
                //allows data into the property
                mTotalAmount = value;
            }
        }
        //private data members for the order date property
        private DateTime mOrderDate;
        //order date public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data members for the active property
        private Boolean mCompleted;
        //active public property
        public bool Completed
        {
            get
            {
                //this line of code sends data out of the property
                return mCompleted;
            }
            set
            {
                //this line of code allows data into the property
                mCompleted = value;
            }
        }

        public bool Active { get; set; }

        public bool Find(int OrderId)
        {
            //create an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the datbase to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["Completed"]);
                //return that the data was found
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating that the data was not found
                return false;
            }
        }
    }
}