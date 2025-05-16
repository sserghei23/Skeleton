using System;
using Microsoft.SqlServer.Server;

namespace ClassLibrary
{
    public class clsCheckout
    {
        //private data member for the address id property
        private string mTotalCartValue;
        //cartId public property
        public string TotalCartValue
        {
            get
            {
                return mTotalCartValue;
            }
            set
            {
                mTotalCartValue = value;
            }
        }


        
        private bool mCheckedOut;
        //dateadded public property
        public bool CheckedOut
        {
            get
            {
                return mCheckedOut;
            }
            set
            {
                mCheckedOut = value;
            }
        }

        
        
        
        public Int32 mCustomerId; //{ get; private set; }

        //dateadded public property
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public Int32 mWatchId; //{ get; private set; }
                               //dateadded public property
        public Int32 WatchId
        {
            get
            {
                return mWatchId;
            }
            set
            {
                mWatchId = value;
            }
        }

        public Int32 mCartId; //{ get; private set; }
                              //dateadded public property
        public Int32 CartId
        {
            get
            {
                return mCartId;
            }
            set
            {
                mCartId = value;
            }
        }

        public DateTime mDateAdded; //{ get; private set; }
                                    //dateadded public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

       

        public bool Find(int CartId)
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //add a parameter for thos cart id seerch
            DB.AddParameter("@CartId", CartId);
            //execute the stored procedure
            DB.Execute("sproc_tblCheckout_FilterByCartId");
            //if one record is found there should be either one or zero
            if (DB.Count == 1)
            {
                mCartId = Convert.ToInt32(DB.DataTable.Rows[0]["CartId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mWatchId = Convert.ToInt32(DB.DataTable.Rows[0]["WatchId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCheckedOut = Convert.ToBoolean(DB.DataTable.Rows[0]["CheckedOut"]);
                mTotalCartValue = Convert.ToString(DB.DataTable.Rows[0]["TotalCartValue"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                
                //return false indicting there is a problem
                return false;
            }

        }

      

        public string Valid(string cartId, string watchId, string customerId, string dateAdded, string totalCartValue)
        {
            String Error = "";
            DateTime DateTemp;
            if (totalCartValue.Length == 0)
            {
                //record the error
                Error = Error + "The cart may not be empty";
            }
            if (totalCartValue.Length > 4)
            {
                Error = Error + "The cart must be less than six characters";
            }

            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //
                DateTemp = Convert.ToDateTime(dateAdded);
                //

                
                if (DateTemp == DateComp)
                {
                    Error = Error + "The date cannot be blank";
                }

                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The date was not valid";
            }
            return Error ;
        }
    }
}












