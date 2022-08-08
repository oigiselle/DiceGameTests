using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller.Models
{
    public class Die
    {
        public String Name { get; set; }
        public int NumSides { get; set; }
        public int  CurrentSide { get; set; }

        public Die()
        {
            NumSides = 6;
            Name = "d6";
            Roll();

        }

        public Die(int numSides)
        {
            NumSides = numSides;
            Name = "d" + numSides;
            Roll();

        }


        public void Roll()
        {
            Random random = new Random();
            CurrentSide = random.Next(NumSides) + 1;
        }

    }
}
