using System;

namespace GURPSCommonConcepts
{
    internal static class modGlobal
    {
        /// <summary>
        /// The main random number generator for all die rolls
        /// </summary>
        private static readonly Random randomGen = new Random();

        /// <summary>
        /// Simulate a single die roll
        /// </summary>
        /// <returns></returns>
        public static int Roll()
        {
            return randomGen.Next(1, 7);
        }

        /// <summary>
        /// Simulate multiple die rolls
        /// </summary>
        /// <param name="numRolls">How many die the user wants to roll</param>
        /// <returns></returns>
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