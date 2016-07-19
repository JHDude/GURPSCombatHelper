using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPSCommonConcepts
{
    static class modGlobal
    {
        private static readonly Random randomGen = new Random();

        public static int Roll()
        {
            return randomGen.Next(1, 7);
        }

        public static int RollMultiple(int numRolls)
        {
            int tally = 0;
            for (int i = 0; i < numRolls; i++)
            {
                tally += Roll();
            }

            return tally;
        }
    }
}
