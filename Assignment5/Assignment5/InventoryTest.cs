using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    [TestFixture]
    public class InventoryTest
    {
        Inventory inventory = new Inventory(5);
        Item item1 = new Item("Sword", 1, ItemGroup.Equipment);
        Item item2 = new Item("Axe", 1, ItemGroup.Equipment);

        [SetUp]
        public void SetUp()
        {
            inventory.Reset();
            inventory.AddItem(item1);
        }

        [TearDown]
        public void CleanUp()
        {
            inventory.Reset();
        }


        [Test]
        public void RemoveItemFound()
        {
            int slot = inventory.AvailableSlots;
            Item item;

            Assert.IsTrue(inventory.TakeItem("Sword", out item));
            Assert.AreEqual(slot + 1, inventory.AvailableSlots);
        }

        [Test]
        public void RemoveItemNotFound()
        {
            int slot = inventory.AvailableSlots;
            Item item;
            Assert.IsFalse(inventory.TakeItem("Axe", out item));
            Assert.AreEqual(slot, inventory.AvailableSlots);
        }

        [Test]
        public void AddItem()
        {
            Assert.IsTrue(inventory.AddItem(item2));
            Assert.AreEqual(3, inventory.AvailableSlots);

            List<Item> items = inventory.ListAllItems();
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual(item1, items[0]);
            Assert.AreEqual(item2, items[1]);
        }

        [Test]
        public void RestInventory()
        {
            inventory.Reset();
            Assert.AreEqual(inventory.MaxSlots, inventory.AvailableSlots);
        }
    }
}
