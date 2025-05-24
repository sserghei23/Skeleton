using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //Private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //Return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
            public clsCustomer ThisCustomer
        {
            get
            {
                //Return the private data
                return mThisCustomer;
            }
            set
            {
                //set the Pribvate data
                mThisCustomer = value;
            }
        }




       //// constructor for the class
       // public clsCustomerCollection()
       // {
       //     //create the items of test data
       //     clsCustomer TestItem = new clsCustomer();
       //     //set its properties
       //     TestItem.IsActive = true;
       //     TestItem.CustomerId = 1;
       //     TestItem.DateRegistered = DateTime.Now;
       //     TestItem.PostCode = "LE4 0BA";
       //     TestItem.FullName = "Vaydang";
       //     TestItem.Email = "vaydang02@dhdh.com";
       //     TestItem.PhoneNumber = "7727628467";
       //     //Add the test item to the test list
       //     mCustomerList.Add(TestItem);
       //     //Re Initialise the Object for some new data
       //     TestItem = new clsCustomer();
       //     //set its properties
       //     TestItem.IsActive = true;
       //     TestItem.CustomerId = 2;
       //     TestItem.DateRegistered = DateTime.Now;
       //     TestItem.PostCode = "LE0 2BB";
       //     TestItem.FullName = "David";
       //     TestItem.Email = "david12@hotmail.com";
       //     TestItem.PhoneNumber = "7368000112";
       //     //add the items to the test list
       //     mCustomerList.Add(TestItem);

       // }

        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
            //create a black address
            clsCustomer AnCustomer = new clsCustomer();
                //Read in the fields for the current record
                AnCustomer.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.DateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRegistered"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //Add the record to the private data number
                mCustomerList.Add(AnCustomer);
                //Point at the next record
                Index++;
            }

         


        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //conncet tp the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);

            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            //Update an existing record based on the values of thisCustomer
            //Connect to the DataBase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);

            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //Delete the record pointed to by this Customer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //Execute the stored procedure
            DB.Execute("Sproc_tblCustomer_Delete");
        }
    }
}

