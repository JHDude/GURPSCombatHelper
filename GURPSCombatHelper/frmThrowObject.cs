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
    public partial class frmThrowObject : Form
    {
        public string ReturnVal { get; set; }

        public frmThrowObject()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            CombatActions.CombatActions throwAction = new CombatActions.CombatActions();
            CombatActions.CombatActionsTypes.Strength ST = CombatActions.CombatActionsTypes.Strength.NewStrength(decimal.ToInt32(nudST.Value));
            ReturnVal = throwAction.ThrowObject(ST, decimal.ToInt32(nudWeight.Value));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            ReturnVal = "";
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
