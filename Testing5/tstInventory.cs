using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstInventory
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsInventory anInventory = new clsInventory();
            Assert.IsNotNull(anInventory);

        }
        [TestMethod]
        public void InventoryIdPropertyOK()
        {
            clsInventory inventory = new clsInventory();
            int TestData = 1;
            inventory.InventoryId = TestData;
            Assert.AreEqual(inventory.InventoryId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsInventory inventory = new clsInventory();
            string TestData = "web Submariner";
            inventory.Name = TestData;
            Assert.AreEqual(inventory.Name, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            clsInventory inventory = new clsInventory();
            string TestData = "5J2K17";
            inventory.Model = TestData;
            Assert.AreEqual(inventory.Model, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsInventory inventory = new clsInventory();
            int TestData = 12000;
            inventory.Price = TestData;
            Assert.AreEqual(inventory.Price, TestData);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            clsInventory inventory = new clsInventory();
            int TestData = 5;
            inventory.Stock = TestData;
            Assert.AreEqual(inventory.Stock, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsInventory inventory = new clsInventory();
            string TestData = "Luxury web watch with vibranium body";
            inventory.Description = TestData;
            Assert.AreEqual(inventory.Description, TestData);
        }

        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            clsInventory inventory = new clsInventory();
            bool TestData = true;
            inventory.IsAvailable = TestData;
            Assert.AreEqual(inventory.IsAvailable, TestData);
        }

    }
}
