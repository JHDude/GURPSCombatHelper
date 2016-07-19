using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GURPSCombatHelper
{
    public partial class frmMainCombat : Form
    {
        /// <summary>
        /// All actors currently in the fight
        /// </summary>
        private List<GURPSStats.GURPSCharacter> mActorList;
        
        public frmMainCombat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds another actor to the turn order list
        /// </summary>
        private void addActor()
        {

        }

        /// <summary>
        /// The actor whose turn it is wants to make an attack...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAttack_Click(object sender, EventArgs e)
        {

        }

        private void cmdAddActor_Click(object sender, EventArgs e)
        {
            addActor();
        }
    }

    
}
