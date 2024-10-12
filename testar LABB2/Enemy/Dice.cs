

namespace LABB2.Enemy

{
    public class Dice
    {
        public int NumberOfDice { get; set; }

        public int SidesPerDice { get; set; }

        public int Modifier { get; set; }


        public Dice(int numberOfDice, int sidesOfDice, int modifier)
        {
            NumberOfDice = numberOfDice;
            SidesPerDice = sidesOfDice;
            Modifier = modifier;
        }

        public int Throw()
        {
            Random rand = new Random();
            int result = 0;

            for(int i = 0; i < NumberOfDice; i++)
            {
                result += rand.Next(1, SidesPerDice + 1);
            }

            result += Modifier;
            return result;
        }
        public override string ToString()
        {
            return $"{NumberOfDice}d{SidesPerDice}+{Modifier}";
        }
    }
}
