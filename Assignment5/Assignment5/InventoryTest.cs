using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    [TestFixture]
    public class InventoryTest
    {
        Inventory inventory = new Inventory(10);
        Item item1 = new Item("Sword", 5, ItemGroup.Equipment);
        Item item2 = new Item("Axe", 5, ItemGroup.Equipment);

        [SetUp]
        public void SetUp()
        {
            inventory.Reset();
            inventory.AddItem(item1);
            inventory.AddItem(item2);
        }
        [TearDown]
        public void CleanUp()
        {
            inventory.Reset();
        }


        [Test]
        public void RemoveItemFound()
        {
            int oldSlots = inventory.AvailableSlots;
            inventory.TakeItem(item1.Name, out Item found);
            Assert.AreEqual(item1.Name, found.Name);
            Assert.IsTrue((oldSlots + 1) == inventory.AvailableSlots);
        }

        [Test]
        public void RemoveItemNotFound()
        {
            int slot = inventory.AvailableSlots;
            inventory.TakeItem("Apple", out Item found);
            Assert.IsTrue(found == null);
            Assert.AreEqual(slot, inventory.AvailableSlots);
        }

        [Test]
        public void AddItem()
        {
            int slot = inventory.AvailableSlots;
            Item newItem = new Item("Bandage", 5, ItemGroup.Consumable);
            inventory.AddItem(newItem);
            Assert.IsTrue((slot - 1) == inventory.AvailableSlots);

            List<Item> list = inventory.ListAllItems();
            bool isExists = false;
            foreach (var i in list)
            {
                if (i.Name == newItem.Name)
                    isExists = true;
            }
            Assert.IsTrue(isExists);
        }

        [Test]
        public void Reset()
        {
            inventory.Reset();
            Assert.IsTrue(inventory.AvailableSlots == 10);
        }
    }
}
