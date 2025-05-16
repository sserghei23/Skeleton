using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCheckoutCollection
    {
        //construxtor
        public clsCheckoutCollection()
        {
            clsCheckout TestItem = new clsCheckout();
            //set priorities
            TestItem.CheckedOut = true;
            TestItem.CartId = 1;
            TestItem.CustomerId = 1;
            TestItem.WatchId = 1;
            TestItem.DateAdded = Convert.ToDateTime("01/05/2024");
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
            TestItem.DateAdded = Convert.ToDateTime("05/07/2024");
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


                mCheckoutList.Add(AnCheckout);
                Index++;
            }
        }

        List<clsCheckout> mCheckoutList = new List<clsCheckout>();
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
        public object ThisCheckout { get; set; }


        

    }
}