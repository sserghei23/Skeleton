using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCheckout
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCheckout AnCheckout  = new clsCheckout ();
            //test to see that it exists
            Assert.IsNotNull(AnCheckout);


        }
    }
}
