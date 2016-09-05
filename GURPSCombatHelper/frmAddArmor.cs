using System.Windows.Forms;

namespace GURPSCombatHelper
{
    public partial class frmAddArmor : Form
    {
        public string name { get; set; }
        public int eyesDR { get; set; }
        public int skullDR { get; set; }
        public int faceDR { get; set; }
        public int neckDR { get; set; }
        public int torsoDR { get; set; }
        public int groinDR { get; set; }
        public int armDR { get; set; }
        public int legDR { get; set; }
        public int handDR { get; set; }
        public int footDR { get; set; }
        public bool isFlexible { get; set; }

        public frmAddArmor()
        {
            InitializeComponent();
        }
    }
}
