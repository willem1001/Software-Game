using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_Game;
using System.Drawing;

namespace UnitTest_Software_Game
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayerTestMethod()
        {
            Point punt = new Point(50, 50); 
            Player player = new Player(new Point(50,50) , false, 1);
            Assert.AreEqual(punt, player.Position, "foute positie");
            Assert.AreEqual(false, player.PowerUp, "Geen correcte powerup");
            Assert.AreEqual(1, player.Hitpoints, "Geen correcte hitpoints");
        }
    }
}
