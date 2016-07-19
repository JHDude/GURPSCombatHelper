using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPSStats
{
    public class GURPSLimitation
    {
        public string name;
        public double costModifier;
        public bool active;

        public GURPSLimitation(string limitationName, double limitationModifier, bool isActive)
        {
            name = limitationName;
            costModifier = limitationModifier;
            active = isActive;
        }

    }

    public class GURPSAdvantages
    {
        public string name;
        public int cost;
        public List<GURPSLimitation> limitations;
    }
}
