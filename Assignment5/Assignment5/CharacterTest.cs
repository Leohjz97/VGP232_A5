using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class CharacterTest
    {
        Character myCharacter = new Character("Wiser", RaceCategory.Human, 100);

        [SetUp]
        public void SetUp()
        {
            myCharacter.Health = myCharacter.MaxHealth;
            myCharacter.IsAlive = true;
        }
        [TearDown]
        public void CleanUp()
        {

        }

        [Test]
        public void TakeDamageAndLive()
        {
            try
            {
                Assert.IsTrue(myCharacter.IsAlive);
                myCharacter.TakeDamage(10);
                Assert.IsTrue(myCharacter.IsAlive);
            }
            catch (Exception)
            {
                Console.WriteLine("TakeDamageAndLive have error");
            }
        }

        [Test]
        public void TakeDamageAndDie()
        {
            Assert.IsTrue(myCharacter.IsAlive);
            myCharacter.TakeDamage(300);
            Assert.IsFalse(myCharacter.IsAlive);
        }
        [Test]
        public void RestoreHealth()
        {
            myCharacter.RestoreHealth(30); 
            Assert.AreEqual(30, myCharacter.Health);
        }

        [Test]
        public void RestoreHealthAndRevive()
        {
            myCharacter.RestoreHealth(30);
            Assert.AreEqual(30, myCharacter.Health);
            Assert.IsTrue(myCharacter.IsAlive);
        }
    }
}
