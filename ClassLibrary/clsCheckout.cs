using System;

namespace ClassLibrary
{
    public class clsCheckout
    {
        //private data member for the address id property
        private Int32 mCartId;





        //cartId public property
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

        public string WatchId { get; set; }
        public string CustomerId { get; set; }
        public int TotalCartValue { get; set; }
        public bool CheckedOut { get; set; }

       
    }
}