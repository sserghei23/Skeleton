using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Active { get; set; }
    }
}