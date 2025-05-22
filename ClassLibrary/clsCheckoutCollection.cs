using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCheckoutCollection
    {
        //constructor
        public clsCheckoutCollection()
        {
            clsCheckout TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = Convert.ToDateTime("20/05/2025");
            TestItem.TotalCartValue = "500";
            //add
            mCheckoutList.Add(TestItem);
            //reinstate
            TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 6;
            TestItem.CustomerId = 4;
            TestItem.WatchId = 4;
            TestItem.DateAdded = Convert.ToDateTime("20/05/2025");
            TestItem.TotalCartValue = "bbbb";
            //add
            mCheckoutList.Add(TestItem);
        
        //public clsCheckoutCollection()
        
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCheckout_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCheckout AnCheckout = new clsCheckout();

                AnCheckout.CartId = Convert.ToInt32(DB.DataTable.Rows[Index]["CartId"]);
                AnCheckout.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCheckout.WatchId = Convert.ToInt32(DB.DataTable.Rows[Index]["WatchId"]);
                AnCheckout.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCheckout.CheckedOut = Convert.ToBoolean(DB.DataTable.Rows[Index]["CheckedOut"]);
                AnCheckout.TotalCartValue = Convert.ToString(DB.DataTable.Rows[Index]["TotalCartValue"]);
                //
                mCheckoutList.Add(AnCheckout);
                Index++;
            }

        }
    


        

        public List<clsCheckout> CheckoutList
        {
            get
            {
                return mCheckoutList;
            }
            set
            {
                mCheckoutList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCheckoutList.Count;
            }
            set
            {
                //later 
            }
        }
        
        

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@WatchId", mThisCheckout.WatchId);
            DB.AddParameter("@CustomerId", mThisCheckout.CustomerId);
            DB.AddParameter("@DateAdded", mThisCheckout.DateAdded);
            DB.AddParameter("@TotalCartValue", mThisCheckout.TotalCartValue);
            DB.AddParameter("@CheckedOut", mThisCheckout.CheckedOut);
            return DB.Execute("sproc_tblCheckout_Insert");          
        }

        public void Update()
        {
            //update
            //cpnnect to database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartId", mThisCheckout.CartId);
            DB.AddParameter("@WatchId", mThisCheckout.WatchId);
            DB.AddParameter("@CustomerId", mThisCheckout.CustomerId);
            DB.AddParameter("@DateAdded", mThisCheckout.DateAdded);
            DB.AddParameter("@TotalCartValue", mThisCheckout.TotalCartValue);
            DB.AddParameter("@CheckedOut", mThisCheckout.CheckedOut);
            DB.Execute("sproc_tblCheckout_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartId", mThisCheckout.CartId);
            DB.Execute("sproc_tblCheckout_Delete");
        }
        
        
     
        public void ReportByTotalCartValue(string TotalCartValue)
        {
            //filter
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TotalCartValue", TotalCartValue);
            DB.Execute("sproc_tblCheckout_FilterByTotalCartValue");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCheckoutList = new List<clsCheckout>();
            while (Index < RecordCount)
            {
                clsCheckout AnCheckout = new clsCheckout();
                AnCheckout.CartId = Convert.ToInt32(DB.DataTable.Rows[Index]["CartId"]);
                AnCheckout.WatchId = Convert.ToInt32(DB.DataTable.Rows[Index]["WatchId"]);
                AnCheckout.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCheckout.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCheckout.TotalCartValue = Convert.ToString(DB.DataTable.Rows[Index]["TotalCartValue"]);
                AnCheckout.CheckedOut = Convert.ToBoolean(DB.DataTable.Rows[Index]["CheckedOut"]);
                mCheckoutList.Add(AnCheckout);
                Index++;
            }
        }

        List<clsCheckout> mCheckoutList = new List<clsCheckout>();
        clsCheckout mThisCheckout = new clsCheckout();

        public clsCheckout ThisCheckout
        {
            get
            {
                return mThisCheckout;
            }
            set
            {
                mThisCheckout = value;
            }
        }
       



    }
}
