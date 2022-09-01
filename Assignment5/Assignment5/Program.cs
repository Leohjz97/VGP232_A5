using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            Character hero = new Character("Jim Raynor", RaceCategory.Human, 100);

            Console.WriteLine("{0} has entered the BATTLEFIELD", hero.Name);

            string monster = "Hydralisk";
            int damage = 10;

            Console.WriteLine("A {0} appeared and attacks {1}", monster, hero.Name);

            Console.WriteLine("{0} takes {1} damage", hero.Name, damage);

            hero.TakeDamage(damage);
            Console.WriteLine(hero);

            string item = "small health potion";
            int restoreAmount = 10;

            Console.WriteLine("{0} find a {1} and drinks it", hero.Name, item);

            Console.WriteLine("{0} restores {1} health", hero.Name, restoreAmount);

            hero.RestoreHealth(restoreAmount);

            Console.WriteLine(hero);

            if (hero.IsAlive)
            {
                Console.WriteLine("Congratulations! {0} survived.", hero.Name);
            }
            else
            {
                Console.WriteLine("{0} has died.", hero.Name);
            }

            //// TODO: Create an inventory
            //Inventory inventory = new Inventory(5);
            //Console.WriteLine("An inventory has been created.");
            //
            //// TODO: Add 2 items to the inventory
            //Item sword = new Item("Sword", 1, ItemGroup.Equipment);
            //Item axe = new Item("Axe", 1, ItemGroup.Equipment);
            //inventory.AddItem(sword);
            //inventory.AddItem(axe);
            //Console.WriteLine("Two items have been added");
            //
            //// Verify the number of items in the inventory.
            //Console.WriteLine("\nList of items.");
            //inventory.ListAllItems();
        }
    }
}
