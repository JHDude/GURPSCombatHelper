using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GURPSCommonConcepts;

namespace GURPSStats
{
    public class GURPSCharacter
    {
        //Primary Attributes
        private attStrength mST;  //Strength
        private int mDX;  //Dexterity
        private int mIQ;  //Intelligence
        private int mHT;  //Health

        //Secondary attributes
        private DiceAndModifier mThrustDamage;
        private DiceAndModifier mSwingDamage;
    }
}
