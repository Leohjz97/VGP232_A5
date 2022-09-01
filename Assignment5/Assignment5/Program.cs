using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            // TODO: Create an inventory
            Inventory inventory = new Inventory(10);
            Console.WriteLine("An inventory has been created.");

            // TODO: Add 2 items to the inventory
            Item sword = new Item("Sword", 5, ItemGroup.Equipment);
            Item axe = new Item("Axe", 5, ItemGroup.Equipment);


            // Verify the number of items in the inventory.
            //Console.WriteLine("\nList of items.");
            //inventory.ListAllItems();
        }
    }
}
