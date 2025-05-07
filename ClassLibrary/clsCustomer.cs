using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool CustomerId { get; set; }
        public DateTime DateRegistered { get; set; }
        public string PostCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public short Password { get; set; }
    }
}