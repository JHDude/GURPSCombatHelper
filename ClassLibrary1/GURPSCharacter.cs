using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GURPSCommonConcepts;

namespace GURPSStats
{
    /// <summary>
    /// Contains only the necessary information to define an actor for the combat helper
    /// </summary>
    public class GURPSCharacter
    {
        public string Name { get; set; }
        public int ST { get; set; }
        public int DX { get; set; }
        public int INT { get; set; }
        public int HT { get; set; }


    }
}
