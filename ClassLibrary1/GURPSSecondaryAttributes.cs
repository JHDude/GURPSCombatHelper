using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GURPSCommonConcepts;

namespace GURPSStats
{
    public class GURPSSecondaryAttributes
    {

    }
    
    /// <summary>
    /// Base thrust damage. Dependent upon current strength
    /// </summary>
    public class attThrust
    {
        private int mCurrStrength;
        private DiceAndModifier mThrust;

        /// <summary>
        /// Current strength value this thrust damage corresponds to
        /// </summary>
        public int CurrStrength
        {
            get
            {
                return mCurrStrength;
            }

            set
            {
                mCurrStrength = value;
                mThrust = updateThrust(value);  //If strength changes, update the thrust damage attribute
            }
        }

        public DiceAndModifier ThrustDamage
        {
            get
            {
                return mThrust;
            }
        }

        private DiceAndModifier updateThrust(int nStrength)
        {
            DiceAndModifier output = new DiceAndModifier();
            switch (nStrength)
            {
                case 1:
                    output = new DiceAndModifier(1, -6);
                    break;

                case 2:
                    output = new DiceAndModifier(1, -6);
                    break;

                case 3:
                    output = new DiceAndModifier(1, -5);
                    break;

                case 4:
                    output = new DiceAndModifier(1, -5);
                    break;

                case 5:
                    output = new DiceAndModifier(1, -4);
                    break;

                case 6:
                    output = new DiceAndModifier(1, -4);
                    break;

                case 7:
                    output = new DiceAndModifier(1, -3);
                    break;

                case 8:
                    output = new DiceAndModifier(1, -3);
                    break;

                case 9:
                    output = new DiceAndModifier(1, -2);
                    break;

                case 10:
                    output = new DiceAndModifier(1, -2);
                    break;

                case 11:
                    output = new DiceAndModifier(1, -1);
                    break;

                case 12:
                    output = new DiceAndModifier(1, -1);
                    break;

                case 13:
                    output = new DiceAndModifier(1, 0);
                    break;

                case 14:
                    output = new DiceAndModifier(1, 0);
                    break;

                case 15:
                    output = new DiceAndModifier(1, 1);
                    break;

                case 16:
                    output = new DiceAndModifier(1, 1);
                    break;

                case 17:
                    output = new DiceAndModifier(1, 2);
                    break;

                case 18:
                    output = new DiceAndModifier(1, 2);
                    break;

                case 19:
                    output = new DiceAndModifier(2, -1);
                    break;

                case 20:
                    output = new DiceAndModifier(2, -1);
                    break;

                case 21:
                    output = new DiceAndModifier(2, 0);
                    break;

                case 22:
                    output = new DiceAndModifier(2, 0);
                    break;

                case 23:
                    output = new DiceAndModifier(2, 1);
                    break;

                case 24:
                    output = new DiceAndModifier(2, 1);
                    break;

                case 25:
                    output = new DiceAndModifier(2, 2);
                    break;

                case 26:
                    output = new DiceAndModifier(2, 2);
                    break;

                case 27:
                    output = new DiceAndModifier(3, -1);
                    break;

                case 28:
                    output = new DiceAndModifier(3, -1);
                    break;

                case 29:
                    output = new DiceAndModifier(3, 0);
                    break;

                case 30:
                    output = new DiceAndModifier(3, 0);
                    break;

                case 31:
                    output = new DiceAndModifier(3, 1);
                    break;

                case 32:
                    output = new DiceAndModifier(3, 1);
                    break;

                case 33:
                    output = new DiceAndModifier(3, 2);
                    break;

                case 34:
                    output = new DiceAndModifier(3, 2);
                    break;

                case 35:
                    output = new DiceAndModifier(4, -1);
                    break;

                case 36:
                    output = new DiceAndModifier(4, -1);
                    break;

                case 37:
                    output = new DiceAndModifier(4, 0);
                    break;

                case 38:
                    output = new DiceAndModifier(4, 0);
                    break;

                case 39:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 40:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 41:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 42:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 43:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 44:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 45:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 46:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 47:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 48:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 49:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 50:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 51:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 52:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 53:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 54:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 55:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 56:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 57:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 58:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 59:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 60:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 61:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 62:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 63:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 64:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 65:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 66:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 67:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 68:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 69:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 70:
                    output = new DiceAndModifier(8, 0);
                    break;

                case 71:
                    output = new DiceAndModifier(8, 0);
                    break;

                case 72:
                    output = new DiceAndModifier(8, 0);
                    break;

                case 73:
                    output = new DiceAndModifier(8, 0);
                    break;

                case 74:
                    output = new DiceAndModifier(8, 0);
                    break;

                case 75:
                    output = new DiceAndModifier(8, 2);
                    break;

                case 76:
                    output = new DiceAndModifier(8, 2);
                    break;

                case 77:
                    output = new DiceAndModifier(8, 2);
                    break;

                case 78:
                    output = new DiceAndModifier(8, 2);
                    break;

                case 79:
                    output = new DiceAndModifier(8, 2);
                    break;

                case 80:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 81:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 82:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 83:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 84:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 85:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 86:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 87:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 88:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 89:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 90:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 91:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 92:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 93:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 94:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 95:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 96:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 97:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 98:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 99:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 100:
                    output = new DiceAndModifier(11, 0);
                    break;   
                    
                default:
                    //2 cases: ST < 1 (return 0, 0), or ST > 100
                    if (nStrength < 1)
                    {
                        //No matter how hard you try, if you have no strength you aren't going to do anythin.
                        output = new DiceAndModifier(0, 0);
                    }
                    else
                    {
                        //Add 1d per 10 points above 100
                        int dieToAdd = (int)Math.Floor(nStrength / 100.0);
                        output = new DiceAndModifier(11 + dieToAdd, 0);
                    }
                    break;
            }
            return output;

        }
    }

    /// <summary>
    /// Basic swing damage. Dependent upon current strength
    /// </summary>
    public class attSwing
    {
        private int mCurrentStrength;
        private DiceAndModifier mSwing;

        public int CurrentStrength
        {
            get
            {
                return mCurrentStrength;
            }

            set
            {
                mCurrentStrength = value;
                mSwing = updateSwing(value);
            }
        }

        public DiceAndModifier Swing
        {
            get
            {
                return mSwing;
            }

        }

        private DiceAndModifier updateSwing(int nStrength)
        {
            DiceAndModifier output = new DiceAndModifier();
            switch (nStrength)
            {
                case 1:
                    output = new DiceAndModifier(1, -5);
                    break;

                case 2:
                    output = new DiceAndModifier(1, -5);
                    break;

                case 3:
                    output = new DiceAndModifier(1, -4);
                    break;

                case 4:
                    output = new DiceAndModifier(1, -4);
                    break;

                case 5:
                    output = new DiceAndModifier(1, -3);
                    break;

                case 6:
                    output = new DiceAndModifier(1, -3);
                    break;

                case 7:
                    output = new DiceAndModifier(1, -2);
                    break;

                case 8:
                    output = new DiceAndModifier(1, -2);
                    break;

                case 9:
                    output = new DiceAndModifier(1, -1);
                    break;

                case 10:
                    output = new DiceAndModifier(1, 0);
                    break;

                case 11:
                    output = new DiceAndModifier(1, 1);
                    break;

                case 12:
                    output = new DiceAndModifier(1, 2);
                    break;

                case 13:
                    output = new DiceAndModifier(2, -1);
                    break;

                case 14:
                    output = new DiceAndModifier(2, 0);
                    break;

                case 15:
                    output = new DiceAndModifier(2, 1);
                    break;

                case 16:
                    output = new DiceAndModifier(2, 2);
                    break;

                case 17:
                    output = new DiceAndModifier(3, -1);
                    break;

                case 18:
                    output = new DiceAndModifier(3, 0);
                    break;

                case 19:
                    output = new DiceAndModifier(3, 1);
                    break;

                case 20:
                    output = new DiceAndModifier(3, 2);
                    break;

                case 21:
                    output = new DiceAndModifier(4, -1);
                    break;

                case 22:
                    output = new DiceAndModifier(4, 0);
                    break;

                case 23:
                    output = new DiceAndModifier(4, 1);
                    break;

                case 24:
                    output = new DiceAndModifier(4, 2);
                    break;

                case 25:
                    output = new DiceAndModifier(5, -1);
                    break;

                case 26:
                    output = new DiceAndModifier(5, 0);
                    break;

                case 27:
                    output = new DiceAndModifier(5, 1);
                    break;

                case 28:
                    output = new DiceAndModifier(5, 1);
                    break;

                case 29:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 30:
                    output = new DiceAndModifier(5, 2);
                    break;

                case 31:
                    output = new DiceAndModifier(6, -1);
                    break;

                case 32:
                    output = new DiceAndModifier(6, -1);
                    break;

                case 33:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 34:
                    output = new DiceAndModifier(6, 0);
                    break;

                case 35:
                    output = new DiceAndModifier(6, 1);
                    break;

                case 36:
                    output = new DiceAndModifier(6, 1);
                    break;

                case 37:
                    output = new DiceAndModifier(6, 2);
                    break;

                case 38:
                    output = new DiceAndModifier(6, 2);
                    break;

                case 39:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 40:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 41:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 42:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 43:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 44:
                    output = new DiceAndModifier(7, -1);
                    break;

                case 45:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 46:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 47:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 48:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 49:
                    output = new DiceAndModifier(7, 1);
                    break;

                case 50:
                    output = new DiceAndModifier(8, -1);
                    break;

                case 51:
                    output = new DiceAndModifier(8, -1);
                    break;

                case 52:
                    output = new DiceAndModifier(8, -1);
                    break;

                case 53:
                    output = new DiceAndModifier(8, -1);
                    break;

                case 54:
                    output = new DiceAndModifier(8, -1);
                    break;

                case 55:
                    output = new DiceAndModifier(8, 1);
                    break;

                case 56:
                    output = new DiceAndModifier(8, 1);
                    break;

                case 57:
                    output = new DiceAndModifier(8, 1);
                    break;

                case 58:
                    output = new DiceAndModifier(8, 1);
                    break;

                case 59:
                    output = new DiceAndModifier(8, 1);
                    break;

                case 60:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 61:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 62:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 63:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 64:
                    output = new DiceAndModifier(9, 0);
                    break;

                case 65:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 66:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 67:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 68:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 69:
                    output = new DiceAndModifier(9, 2);
                    break;

                case 70:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 71:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 72:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 73:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 74:
                    output = new DiceAndModifier(10, 0);
                    break;

                case 75:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 76:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 77:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 78:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 79:
                    output = new DiceAndModifier(10, 2);
                    break;

                case 80:
                    output = new DiceAndModifier(11, 0);
                    break;

                case 81:
                    output = new DiceAndModifier(11, 0);
                    break;

                case 82:
                    output = new DiceAndModifier(11, 0);
                    break;

                case 83:
                    output = new DiceAndModifier(11, 0);
                    break;

                case 84:
                    output = new DiceAndModifier(11, 0);
                    break;

                case 85:
                    output = new DiceAndModifier(11, 2);
                    break;

                case 86:
                    output = new DiceAndModifier(11, 2);
                    break;

                case 87:
                    output = new DiceAndModifier(11, 2);
                    break;

                case 88:
                    output = new DiceAndModifier(11, 2);
                    break;

                case 89:
                    output = new DiceAndModifier(11, 2);
                    break;

                case 90:
                    output = new DiceAndModifier(12, 0);
                    break;

                case 91:
                    output = new DiceAndModifier(12, 0);
                    break;

                case 92:
                    output = new DiceAndModifier(12, 0);
                    break;

                case 93:
                    output = new DiceAndModifier(12, 0);
                    break;

                case 94:
                    output = new DiceAndModifier(12, 0);
                    break;

                case 95:
                    output = new DiceAndModifier(12, 2);
                    break;

                case 96:
                    output = new DiceAndModifier(12, 2);
                    break;

                case 97:
                    output = new DiceAndModifier(12, 2);
                    break;

                case 98:
                    output = new DiceAndModifier(12, 2);
                    break;

                case 99:
                    output = new DiceAndModifier(12, 2);
                    break;

                case 100:
                    output = new DiceAndModifier(13, 0);
                    break;

                default:
                    //2 cases: ST < 1 (return 0, 0), or ST > 100
                    if (nStrength < 1)
                    {
                        //No matter how hard you try, if you have no strength you aren't going to do anythin.
                        output = new DiceAndModifier(0, 0);
                    }
                    else
                    {
                        //Add 1d per 10 points above 100
                        int dieToAdd = (int)Math.Floor(nStrength / 100.0);
                        output = new DiceAndModifier(13 + dieToAdd, 0);
                    }
                    break;
            }
            return output;

        }
    }
}
