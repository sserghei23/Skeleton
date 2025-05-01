using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create and instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //Test to see that it exists
            Assert.IsNotNull(anOrder);
        }
    }
}
