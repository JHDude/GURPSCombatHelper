using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DiceAndModifier()
        {
            numDice = 1;
            modifier = 1;
        }

        public DiceAndModifier(int die, int mod)
        {
            numDice = die;
            modifier = mod;
        }

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
        
        public int RollDAM()
        {
            return modGlobal.RollMultiple(numDice) + modifier;
        }
    }
}
