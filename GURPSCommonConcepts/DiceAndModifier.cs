namespace GURPSCommonConcepts
{
    /// <summary>
    /// Describes the number of dice to roll, and modifier to tack on for a given task
    /// </summary>
    public class DiceAndModifier
    {
        /// <summary>
        /// Number of dice to roll
        /// </summary>
        public int numDice;

        /// <summary>
        /// Modifier to add or subtract from roll
        /// </summary>
        public int modifier;

        /// <summary>
        /// Creates a new dummy Dice And Modifier
        /// </summary>
        public DiceAndModifier() : this(1, 0)
        {
        }

        /// <summary>
        /// Creates a new Dice And Modifier object
        /// </summary>
        /// <param name="die">The number of dice to roll</param>
        /// <param name="mod">What to add to the die roll</param>
        public DiceAndModifier(int die, int mod)
        {
            numDice = die;
            modifier = mod;
        }

        /// <summary>
        /// Linguistic representation of Dice And Modifier
        /// </summary>
        public string DAMLinguistic
        {
            get
            {
                string output = "";
                output += numDice.ToString();
                output += "d";
                if (modifier < 0)
                {
                    output += "-";
                }
                else
                {
                    output += "+";
                }
                output += modifier.ToString();

                return output;
            }
        }

        /// <summary>
        /// Calculates the amount of damage the Dice And Modifier object will do
        /// </summary>
        /// <returns>A raw damage value</returns>
        public int RollDAM()
        {
            return modGlobal.RollMultiple(numDice) + modifier;
        }
    }
}