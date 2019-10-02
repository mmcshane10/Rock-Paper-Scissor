using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
    [TestClass]
    public class RockTest
    {
        [TestMethod]
        public void Item_GetsTheEncodedValueFromObject_1()
        {
            //arrange
            Item newItem = new Item("rock");
            //act
            int result = newItem.Number;
            //assert
            Assert.AreEqual(1,result);
        }
        [TestMethod]
        public void DetermineWinner_showsWhoWins_Rock()
        {
            //arrange
            Item player1 = new Item("rock");
            Item player2 = new Item("scissors");
            //act
            Game newGame = new Game(player1, player2);
            string result = newGame.DetermineWinner();
            //assert
            Assert.AreEqual("rock wins", result);
        }
    }
}