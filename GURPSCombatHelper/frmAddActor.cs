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
        public int Block { get; set; }
        public int BaseDodge { get; set; }

        public float Encumberance { get; set; }
        
        /// <summary>
        /// Form that allows the user to create a new actor for combat in GURPS
        /// </summary>
        public frmAddActor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User changed his mind. Just leave.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Save out all values to return to the calling program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e)
        {
            Strength = (int)nudST.Value;
            Dexterity = (int)nudDX.Value;
            Intelligence = (int)nudIQ.Value;
            Health = (int)nudHT.Value;

            DamageReduction = (int)nudDR.Value;
            Parry = (int)nudParry.Value;
            Block = (int)nudBlock.Value;
            BaseDodge = (int)nudBaseDodge.Value;

            float tempEncumberance;
            var success = float.TryParse(txtEncumberance.Text, out tempEncumberance);
            if (success)
            {
                Encumberance = tempEncumberance;
            }
            else
            {
                //Bad encumberance value. Chastize the user, and get him/her to try again
                MessageBox.Show("Could not convert Encumberance to a number!\n" + txtEncumberance.Text);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdEquipmentList_Click(object sender, EventArgs e)
        {

        }
    }
}