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
        public BattleLog bLog;
        public frmMainCombat()
        {
            InitializeComponent();
            bLog = new BattleLog();
            BattleTimer.Start();
            bLog.addLog("I live once more...");
        }

        /// <summary>
        /// Adds another actor to the turn order list
        /// </summary>
        private void addActor()
        {
            bLog.addLog("Tracking actors is not currently supported yet. Stay tuned!");
        }

        private void attack()
        {
            bLog.addLog("Attacks are not currently supported yet. Stay tuned!");
        }

        /// <summary>
        /// The actor whose turn it is wants to make an attack...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAttack_Click(object sender, EventArgs e)
        {
            attack();
        }

        /// <summary>
        /// Adds a new character or NPC to the battle simulator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddActor_Click(object sender, EventArgs e)
        {
            addActor();
        }

        /// <summary>
        /// Controls the writing to the battle log. Log can only be written to each tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BattleTimer_Tick(object sender, EventArgs e)
        {
            if (bLog.anyFresh())
            {
                List<string> freshLogs = bLog.getFreshLogs();
                txtBattleLog.SuspendLayout();
                foreach (string msg in freshLogs)
                {
                    txtBattleLog.AppendText(msg);
                }
                //txtBattleLog.Update();                
                txtBattleLog.ScrollToCaret();
            }
        }

        private void tsmiThrowObject_Click(object sender, EventArgs e)
        {
            using (var form = new frmThrowObject())
            {
                var result = form.ShowDialog();
                if ((result == DialogResult.OK) && (form.ReturnVal != ""))
                {
                    bLog.addLog(form.ReturnVal);
                }
            }
        }

        private void tsmiAttack_Click(object sender, EventArgs e)
        {
            attack();
        }
    }

    
}
