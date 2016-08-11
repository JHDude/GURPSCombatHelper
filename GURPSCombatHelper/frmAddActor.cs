using System;
using System.Windows.Forms;

namespace GURPSCombatHelper
{
    public partial class frmAddActor : Form
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Health { get; set; }

        public int DamageReduction { get; set; }
        public int Parry { get; set; }
        public int Bloc { get; set; }
        public int BaseDodge { get; set; }

        public float Encumberance { get; set; }


        public frmAddActor()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
        }
    }
}