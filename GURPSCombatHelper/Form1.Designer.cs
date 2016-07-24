namespace GURPSCombatHelper
{
    partial class frmMainCombat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvwTurnOrder = new System.Windows.Forms.ListView();
            this.grbTurnOrder = new System.Windows.Forms.GroupBox();
            this.grbActors = new System.Windows.Forms.GroupBox();
            this.cmdAddActor = new System.Windows.Forms.Button();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.cmdAttack = new System.Windows.Forms.Button();
            this.grbBattleLog = new System.Windows.Forms.GroupBox();
            this.txtBattleLog = new System.Windows.Forms.RichTextBox();
            this.BattleTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiActors = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAttack = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThrowObject = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTurnOrder.SuspendLayout();
            this.grbActors.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.grbBattleLog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwTurnOrder
            // 
            this.lvwTurnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTurnOrder.Location = new System.Drawing.Point(3, 22);
            this.lvwTurnOrder.MultiSelect = false;
            this.lvwTurnOrder.Name = "lvwTurnOrder";
            this.lvwTurnOrder.Size = new System.Drawing.Size(252, 548);
            this.lvwTurnOrder.TabIndex = 0;
            this.lvwTurnOrder.UseCompatibleStateImageBehavior = false;
            this.lvwTurnOrder.View = System.Windows.Forms.View.List;
            // 
            // grbTurnOrder
            // 
            this.grbTurnOrder.Controls.Add(this.lvwTurnOrder);
            this.grbTurnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTurnOrder.Location = new System.Drawing.Point(585, 48);
            this.grbTurnOrder.Name = "grbTurnOrder";
            this.grbTurnOrder.Size = new System.Drawing.Size(258, 573);
            this.grbTurnOrder.TabIndex = 1;
            this.grbTurnOrder.TabStop = false;
            this.grbTurnOrder.Text = "TURN ORDER";
            // 
            // grbActors
            // 
            this.grbActors.Controls.Add(this.cmdAddActor);
            this.grbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbActors.Location = new System.Drawing.Point(12, 290);
            this.grbActors.Name = "grbActors";
            this.grbActors.Size = new System.Drawing.Size(113, 75);
            this.grbActors.TabIndex = 2;
            this.grbActors.TabStop = false;
            this.grbActors.Text = "Actors";
            // 
            // cmdAddActor
            // 
            this.cmdAddActor.Location = new System.Drawing.Point(9, 25);
            this.cmdAddActor.Name = "cmdAddActor";
            this.cmdAddActor.Size = new System.Drawing.Size(82, 32);
            this.cmdAddActor.TabIndex = 1;
            this.cmdAddActor.Text = "Add";
            this.cmdAddActor.UseVisualStyleBackColor = true;
            this.cmdAddActor.Click += new System.EventHandler(this.cmdAddActor_Click);
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.cmdAttack);
            this.grbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbActions.Location = new System.Drawing.Point(12, 371);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(113, 69);
            this.grbActions.TabIndex = 3;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Actions";
            // 
            // cmdAttack
            // 
            this.cmdAttack.Location = new System.Drawing.Point(9, 25);
            this.cmdAttack.Name = "cmdAttack";
            this.cmdAttack.Size = new System.Drawing.Size(82, 32);
            this.cmdAttack.TabIndex = 0;
            this.cmdAttack.Text = "Attack";
            this.cmdAttack.UseVisualStyleBackColor = true;
            this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
            // 
            // grbBattleLog
            // 
            this.grbBattleLog.Controls.Add(this.txtBattleLog);
            this.grbBattleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBattleLog.Location = new System.Drawing.Point(18, 446);
            this.grbBattleLog.Name = "grbBattleLog";
            this.grbBattleLog.Size = new System.Drawing.Size(561, 172);
            this.grbBattleLog.TabIndex = 4;
            this.grbBattleLog.TabStop = false;
            this.grbBattleLog.Text = "BATTLE LOG";
            // 
            // txtBattleLog
            // 
            this.txtBattleLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBattleLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBattleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBattleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBattleLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBattleLog.Location = new System.Drawing.Point(3, 22);
            this.txtBattleLog.Name = "txtBattleLog";
            this.txtBattleLog.ReadOnly = true;
            this.txtBattleLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBattleLog.Size = new System.Drawing.Size(555, 147);
            this.txtBattleLog.TabIndex = 0;
            this.txtBattleLog.Text = "";
            // 
            // BattleTimer
            // 
            this.BattleTimer.Tick += new System.EventHandler(this.BattleTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActors,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiActors
            // 
            this.tsmiActors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.tsmiActors.Name = "tsmiActors";
            this.tsmiActors.Size = new System.Drawing.Size(53, 20);
            this.tsmiActors.Text = "Actors";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAttack,
            this.tsmiThrowObject});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // tsmiAttack
            // 
            this.tsmiAttack.Name = "tsmiAttack";
            this.tsmiAttack.Size = new System.Drawing.Size(146, 22);
            this.tsmiAttack.Text = "Attack";
            // 
            // tsmiThrowObject
            // 
            this.tsmiThrowObject.Name = "tsmiThrowObject";
            this.tsmiThrowObject.Size = new System.Drawing.Size(146, 22);
            this.tsmiThrowObject.Text = "Throw Object";
            this.tsmiThrowObject.Click += new System.EventHandler(this.tsmiThrowObject_Click);
            // 
            // frmMainCombat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 633);
            this.Controls.Add(this.grbBattleLog);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.grbActors);
            this.Controls.Add(this.grbTurnOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainCombat";
            this.Text = "GURPS Combat Helper";
            this.grbTurnOrder.ResumeLayout(false);
            this.grbActors.ResumeLayout(false);
            this.grbActions.ResumeLayout(false);
            this.grbBattleLog.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwTurnOrder;
        private System.Windows.Forms.GroupBox grbTurnOrder;
        private System.Windows.Forms.GroupBox grbActors;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button cmdAttack;
        private System.Windows.Forms.GroupBox grbBattleLog;
        private System.Windows.Forms.RichTextBox txtBattleLog;
        private System.Windows.Forms.Button cmdAddActor;
        private System.Windows.Forms.Timer BattleTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiActors;
        private System.Windows.Forms.ToolStripMenuItem tsmiAttack;
        private System.Windows.Forms.ToolStripMenuItem tsmiThrowObject;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

