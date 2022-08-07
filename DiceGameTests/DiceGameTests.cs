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


        [TestMethod]
        public void OneArgumentDieHasLessThanOrIsEqualTheArgumentNumberOfSides()
        {
            int result = dice.Dice(10);

            Assert.IsTrue(result <= 10);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(-55)]
        public void OneArgumentDieNegativeNumberIsNegativeReturnsZero(int sides)
        {
            int result = dice.Dice(sides);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(20)]

        public void OneArgumentDieIsBetween1andNumberOfSides(int sides)
        {
            int initialize = dice.Dice(sides);

            bool isGreaterOrEqualToZero = initialize > 0;
            bool isLessOrEqualToSix = initialize <= sides;

            Assert.IsTrue(isLessOrEqualToSix && isGreaterOrEqualToZero);
        }



}