
namespace DiceGameTests
{
    class DiceGame
    {
        // 0 arguments Dice

        public int Dice()
        {
          
            int currentNumberUP = Roll(6);

            return currentNumberUP;

        }

        //1 argument dice
        public int Dice(int numberOfSides)
        {         
                if (numberOfSides <= 0) { return 0; };

                int currentNumberUP = Roll(numberOfSides);

                return currentNumberUP;
        }

        //2 arguments dice
        public string Dice(int numberOfSides, int numberOfRolls)
        {
            

            List<int> list = new List<int>();

            if (numberOfSides <= 0 || numberOfRolls <=0 )
            {

                string message = "Error";
                return message ;
            }

            for (int i = 0; i < numberOfRolls; i++)
            {

                int currentNumberUp = Roll(numberOfSides);
                list.Add(currentNumberUp);

            }
            string result = "";
            foreach (int i in list)
            {
                result += i.ToString() + " ";
            }

                return result.Trim();


        }


        //roll method
        public int Roll(int numberOfDiceSides)
        {
            Random random = new Random();
            int currentNumberUp = random.Next(1, numberOfDiceSides + 1);

            return currentNumberUp;

        }

    }   
}
