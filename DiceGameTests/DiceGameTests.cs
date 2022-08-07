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




        [TestMethod]
        [DataRow(10)]
        [DataRow(45)]
        [DataRow(99)]
        [DataRow(2)]
        public void TwoArgumentDieHasLessThanOrISEqualTheArgumentNumberOfSides(int sides)
        {
            var randomNumber = dice.Dice(sides, 1);

            int result = Int32.Parse(randomNumber);


            Assert.IsTrue(result <= sides);
        }

        [TestMethod]
        [DataRow(6, 5)]
        [DataRow(10, 20)]
        [DataRow(5, 2)]
        [DataRow(3, 40)]
        public void TwoArgumentDieListResultHasTheExactLengthOfArgumentNumberRolls(int sides, int rolls)
        {
            string initialize = dice.Dice(sides, rolls);


            string[] elements = initialize.Split(' ');

            int result = elements.Length;

            Assert.AreEqual(rolls, result);

        }

        [TestMethod]
        [DataRow(6, 0)]
        [DataRow(10, -1)]
        [DataRow(5, -5)]
        [DataRow(3, -40)]
        public void TwoArgumentDieNumberOfRolIfIsZeroOrNegativeReturnError(int sides, int rolls)
        {
            string result = dice.Dice(sides, rolls);

            string expected = "Error";

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(5, 1)]
        [DataRow(20, 1)]

        public void TwoArgumentDieIsBetween1andNumberOfSides(int sides, int rolls)
        {
            string initialize = dice.Dice(sides, rolls);

            string[] elements = initialize.Split(' ');

            string first = elements.FirstOrDefault();

            int result = Int32.Parse(first);

            bool isGreaterOrEqualToZero = result > 0;
            bool isLessOrEqualToSix = result <= sides;

            Assert.IsTrue(isLessOrEqualToSix && isGreaterOrEqualToZero);
        }



    }



}