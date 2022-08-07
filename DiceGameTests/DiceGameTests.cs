using DiceGameTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceGameTests
{


    [TestClass]
    public class DiceGameTests
    {
        DiceGame dice = new DiceGame();

        [TestMethod]
        public void DiceNullTest()
        {

            Assert.IsNotNull(dice);
        }

        [TestMethod]
        public void ResultOfZeroArgumentDieIsNotNegative()
        {
            int result = dice.Dice();

            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void ZeroArgumentDieHasLessThanOrIsEqualToSixSides()
        {
            int result = dice.Dice();

            Assert.IsTrue(result <= 6);
        }

        [TestMethod]
        public void ZeroArgumentDieIsBetween1and6()
        {
            int initialize = dice.Dice();

            bool isGreaterOrEqualToZero = initialize > 0;
            bool isLessOrEqualToSix = initialize <= 6;

            Assert.IsTrue(isLessOrEqualToSix && isGreaterOrEqualToZero);
        }


        [TestMethod]
        public void ZeroArgumentDieResultIsNotZero()
        {
            int result = dice.Dice();

            Assert.IsTrue(result != 0);
        }

}