using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates instance of staff
            clsStaff AStaff = new clsStaff();

            //test that the instance is not null
            Assert.IsNotNull(AStaff);
        }
    }
}
