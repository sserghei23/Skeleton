using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsWorking { get; set; }
        public int OrderID { get; set; }
    }
}