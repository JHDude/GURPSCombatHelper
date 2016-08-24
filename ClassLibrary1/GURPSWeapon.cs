using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatActions;

namespace GURPSStats
{
    class GURPSWeapon
    {
        public WeaponType MeleeOrRange { get; set; }
        public WeaponParry Parry { get; set; }
        public WeaponAcc Accuracy { get; set; }

        public GURPSWeapon( WeaponType MOR)
        {
            MeleeOrRange = MOR;
            
        }


    }
}
