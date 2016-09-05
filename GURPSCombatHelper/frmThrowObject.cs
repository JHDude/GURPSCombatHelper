using System;
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
            var throwAction = new CombatActions.CombatActions();
            var ST = CombatActions.Strength.create(decimal.ToInt32(nudST.Value));
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