using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPSStats
{
    public enum AttributeType
    {
        ST, //Strength
        DX, //Dexterity
        IQ, //Intelligence
        HT, //Health
    }

    //class GURPSAttribute
    //{
    //    //public AttributeType attName;
    //    private int attAmount;
    //    //public int attCost;
    //    public List<GURPSLimitation> possibleLimitations; //What limitations can be applied to this attribute

    //}

    /// <summary>
    /// Describes the strength attribute in a GURPS character (or NPC)
    /// </summary>
    public class attStrength
    {
        public const string name = "Strength";
        public const string abbrName = "ST";
        private const int mBaseCost = 10;


        //Fields
        private int mTotalCost;
        private int mAttAmount;
        public readonly GURPSLimitation NoFineManipulators = new GURPSLimitation("No Fine Manipulators", -0.4, false);

        /// <summary>
        /// Multiplicative cost modifier for the ST stat
        /// </summary>
        public double externalCostModifier;

        /// <summary>
        /// How many strength points the character currently has
        /// </summary>
        public int AttributeAmount
        {
            get { return mAttAmount; }
            set
            {
                mAttAmount = value;
                calcCost();
            }
        }

        public bool NMFActive
        {
            set
            {
                NoFineManipulators.active = value;
                calcCost();
            }
        }

        public attStrength()
        {
            externalCostModifier = 0;
            AttributeAmount = 10;
        }

        public attStrength(int stPoints, double extCostMod)
        {
            externalCostModifier = extCostMod;
            AttributeAmount = stPoints;
        }

        /// <summary>
        /// Recalculates the total cost of all the strength points the character has
        /// </summary>
        /// <returns></returns>
        private void calcCost()
        {
            int attributeDifference = AttributeAmount - 10;    //How different our attribute is from normal
            int costPerPoint = mBaseCost;
            double costModifer = externalCostModifier;  //Tack on the external strength modifier
            if (NoFineManipulators.active)  //Only add in NoFineManipulators if the character actually has it :p
            {
                costModifer += NoFineManipulators.costModifier;
            }

            if (costModifer < -0.8) //Cannot reduce strength cost by more than 80%
            {
                costModifer = -0.8;
            }

            costModifer += 1;   //Convert the modifier to a multiplicative percentile

            costPerPoint *= (int)Math.Ceiling(costModifer);    //Calculate the cost per point of strength...

            mTotalCost = attributeDifference * costPerPoint;
        }
    }

    /// <summary>
    /// Describes the dexterity attribute in a GURPS character (or NPC)
    /// </summary>
    public class attDexterity
    {
        public const string name = "Dexterity";
        public const string abbrName = "DX";
        private const int baseCost = 20;

        //Fields
        private int mTotalCost;
        private int mAttAmount;
        public readonly GURPSLimitation NoFineManipulators = new GURPSLimitation("No Fine Manipulators", -0.4, false);

        /// <summary>
        /// Multiplicative cost modifier for the DX stat
        /// </summary>
        public double externalCostModifier;

        /// <summary>
        /// How many dexterity points the character currently has
        /// </summary>
        public int AttributeAmount
        {
            get { return mAttAmount; }
            set
            {
                mAttAmount = value;
                calcCost();
            }
        }
        public bool NMFActive
        {
            set
            {
                NoFineManipulators.active = value;
                calcCost();
            }
        }

        public attDexterity()
        {
            externalCostModifier = 0;
            AttributeAmount = 10;
        }

        public attDexterity(int stPoints, double extCostMod)
        {
            externalCostModifier = extCostMod;
            AttributeAmount = stPoints;
        }

        /// <summary>
        /// Recalculates the total cost of all the dexterity points the character has
        /// </summary>
        /// <returns></returns>
        private void calcCost()
        {
            int attributeDifference = AttributeAmount - 10;    //How different our attribute is from normal
            int costPerPoint = baseCost;
            double costModifer = externalCostModifier;  //Tack on the external dexterity modifier
            if (NoFineManipulators.active)  //Only add in NoFineManipulators if the character actually has it :p
            {
                costModifer += NoFineManipulators.costModifier;
            }

            if (costModifer < -0.8) //Cannot reduce dexterity cost by more than 80%
            {
                costModifer = -0.8;
            }

            costModifer += 1;   //Convert the modifier to a multiplicative percentile

            costPerPoint *= (int)Math.Ceiling(costModifer);    //Calculate the cost per point of dexterity...

            mTotalCost = attributeDifference * costPerPoint;
        }
    }

    /// <summary>
    /// Describes the Intelligence attribute in a GURPS character (or NPC)
    /// </summary>
    public class attIntelligence
    {
        public const string name = "Intelligence";
        public const string abbrName = "IQ";
        private const int baseCost = 20;

        //Fields
        private int mTotalCost;
        private int mAttAmount;

        /// <summary>
        /// Multiplicative cost modifier for the IQ stat
        /// </summary>
        public double externalCostModifier;

        /// <summary>
        /// How many Intelligence points the character currently has
        /// </summary>
        public int AttributeAmount
        {
            get { return mAttAmount; }
            set
            {
                mAttAmount = value;
                calcCost();
            }
        }

        public attIntelligence()
        {
            externalCostModifier = 0;
            AttributeAmount = 10;
        }

        public attIntelligence(int stPoints, double extCostMod)
        {
            externalCostModifier = extCostMod;
            AttributeAmount = stPoints;
        }

        /// <summary>
        /// Recalculates the total cost of all the Intelligence points the character has
        /// </summary>
        /// <returns></returns>
        private void calcCost()
        {
            int attributeDifference = AttributeAmount - 10;    //How different our attribute is from normal
            int costPerPoint = baseCost;
            double costModifer = externalCostModifier;  //Tack on the external Intelligence modifier

            if (costModifer < -0.8) //Cannot reduce Intelligence cost by more than 80%
            {
                costModifer = -0.8;
            }

            costModifer += 1;   //Convert the modifier to a multiplicative percentile

            costPerPoint *= (int)Math.Ceiling(costModifer);    //Calculate the cost per point of Intelligence...

            mTotalCost = attributeDifference * costPerPoint;
        }

    }

    /// <summary>
    /// Describes the Health attribute in a GURPS character (or NPC)
    /// </summary>
     public class attHealth
    {
        public const string name = "Health";
        public const string abbrName = "HT";
        private const int baseCost = 10;

        //Fields
        private int mTotalCost;
        private int mAttAmount;

        /// <summary>
        /// Multiplicative cost modifier for the HT stat
        /// </summary>
        public double externalCostModifier;

        /// <summary>
        /// How many Health points the character currently has
        /// </summary>
        public int AttributeAmount
        {
            get { return mAttAmount; }
            set
            {
                mAttAmount = value;
                calcCost();
            }
        }

        public attHealth()
        {
            externalCostModifier = 0;
            AttributeAmount = 10;
        }

        public attHealth(int stPoints, double extCostMod)
        {
            externalCostModifier = extCostMod;
            AttributeAmount = stPoints;
        }

        /// <summary>
        /// Recalculates the total cost of all the Health points the character has
        /// </summary>
        /// <returns></returns>
        private void calcCost()
        {
            int attributeDifference = AttributeAmount - 10;    //How different our attribute is from normal
            int costPerPoint = baseCost;
            double costModifer = externalCostModifier;  //Tack on the external Health modifier

            if (costModifer < -0.8) //Cannot reduce Health cost by more than 80%
            {
                costModifer = -0.8;
            }

            costModifer += 1;   //Convert the modifier to a multiplicative percentile

            costPerPoint *= (int)Math.Ceiling(costModifer);    //Calculate the cost per point of Health...

            mTotalCost = attributeDifference * costPerPoint;
        }

    }
}
