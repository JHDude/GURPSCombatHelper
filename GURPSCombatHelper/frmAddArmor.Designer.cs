namespace GURPSCombatHelper
{
    partial class frmAddArmor
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
            this.grbArmorLocation = new System.Windows.Forms.GroupBox();
            this.grbHead = new System.Windows.Forms.GroupBox();
            this.lblArmorName = new System.Windows.Forms.Label();
            this.txtArmorName = new System.Windows.Forms.TextBox();
            this.cbxEyes = new System.Windows.Forms.CheckBox();
            this.cbxSkull = new System.Windows.Forms.CheckBox();
            this.cbxFace = new System.Windows.Forms.CheckBox();
            this.nudEyes = new System.Windows.Forms.NumericUpDown();
            this.lblDR = new System.Windows.Forms.Label();
            this.nudSkull = new System.Windows.Forms.NumericUpDown();
            this.nudFace = new System.Windows.Forms.NumericUpDown();
            this.grbBody = new System.Windows.Forms.GroupBox();
            this.nudGroin = new System.Windows.Forms.NumericUpDown();
            this.nudNeck = new System.Windows.Forms.NumericUpDown();
            this.lblBodyDR = new System.Windows.Forms.Label();
            this.nudTorso = new System.Windows.Forms.NumericUpDown();
            this.cbxGroin = new System.Windows.Forms.CheckBox();
            this.cbxNeck = new System.Windows.Forms.CheckBox();
            this.cbxTorso = new System.Windows.Forms.CheckBox();
            this.grbLimbs = new System.Windows.Forms.GroupBox();
            this.nudLegs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudArms = new System.Windows.Forms.NumericUpDown();
            this.cbxLegs = new System.Windows.Forms.CheckBox();
            this.cbxArms = new System.Windows.Forms.CheckBox();
            this.grbFlexible = new System.Windows.Forms.GroupBox();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudFeet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHands = new System.Windows.Forms.NumericUpDown();
            this.cbxFeet = new System.Windows.Forms.CheckBox();
            this.cbxHands = new System.Windows.Forms.CheckBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.grbArmorLocation.SuspendLayout();
            this.grbHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFace)).BeginInit();
            this.grbBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorso)).BeginInit();
            this.grbLimbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArms)).BeginInit();
            this.grbFlexible.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHands)).BeginInit();
            this.SuspendLayout();
            // 
            // grbArmorLocation
            // 
            this.grbArmorLocation.Controls.Add(this.groupBox1);
            this.grbArmorLocation.Controls.Add(this.grbLimbs);
            this.grbArmorLocation.Controls.Add(this.grbBody);
            this.grbArmorLocation.Controls.Add(this.grbHead);
            this.grbArmorLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArmorLocation.Location = new System.Drawing.Point(12, 105);
            this.grbArmorLocation.Name = "grbArmorLocation";
            this.grbArmorLocation.Size = new System.Drawing.Size(409, 350);
            this.grbArmorLocation.TabIndex = 0;
            this.grbArmorLocation.TabStop = false;
            this.grbArmorLocation.Text = "Location";
            // 
            // grbHead
            // 
            this.grbHead.Controls.Add(this.nudFace);
            this.grbHead.Controls.Add(this.nudSkull);
            this.grbHead.Controls.Add(this.lblDR);
            this.grbHead.Controls.Add(this.nudEyes);
            this.grbHead.Controls.Add(this.cbxFace);
            this.grbHead.Controls.Add(this.cbxSkull);
            this.grbHead.Controls.Add(this.cbxEyes);
            this.grbHead.Location = new System.Drawing.Point(6, 25);
            this.grbHead.Name = "grbHead";
            this.grbHead.Size = new System.Drawing.Size(193, 149);
            this.grbHead.TabIndex = 0;
            this.grbHead.TabStop = false;
            this.grbHead.Text = "Head";
            // 
            // lblArmorName
            // 
            this.lblArmorName.AutoSize = true;
            this.lblArmorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmorName.Location = new System.Drawing.Point(13, 13);
            this.lblArmorName.Name = "lblArmorName";
            this.lblArmorName.Size = new System.Drawing.Size(60, 20);
            this.lblArmorName.TabIndex = 1;
            this.lblArmorName.Text = "Name:";
            // 
            // txtArmorName
            // 
            this.txtArmorName.Location = new System.Drawing.Point(79, 15);
            this.txtArmorName.Name = "txtArmorName";
            this.txtArmorName.Size = new System.Drawing.Size(196, 20);
            this.txtArmorName.TabIndex = 2;
            // 
            // cbxEyes
            // 
            this.cbxEyes.AutoSize = true;
            this.cbxEyes.Location = new System.Drawing.Point(7, 46);
            this.cbxEyes.Name = "cbxEyes";
            this.cbxEyes.Size = new System.Drawing.Size(67, 24);
            this.cbxEyes.TabIndex = 0;
            this.cbxEyes.Text = "Eyes";
            this.cbxEyes.UseVisualStyleBackColor = true;
            // 
            // cbxSkull
            // 
            this.cbxSkull.AutoSize = true;
            this.cbxSkull.Location = new System.Drawing.Point(7, 78);
            this.cbxSkull.Name = "cbxSkull";
            this.cbxSkull.Size = new System.Drawing.Size(67, 24);
            this.cbxSkull.TabIndex = 1;
            this.cbxSkull.Text = "Skull";
            this.cbxSkull.UseVisualStyleBackColor = true;
            // 
            // cbxFace
            // 
            this.cbxFace.AutoSize = true;
            this.cbxFace.Location = new System.Drawing.Point(6, 110);
            this.cbxFace.Name = "cbxFace";
            this.cbxFace.Size = new System.Drawing.Size(68, 24);
            this.cbxFace.TabIndex = 2;
            this.cbxFace.Text = "Face";
            this.cbxFace.UseVisualStyleBackColor = true;
            // 
            // nudEyes
            // 
            this.nudEyes.Location = new System.Drawing.Point(121, 45);
            this.nudEyes.Name = "nudEyes";
            this.nudEyes.Size = new System.Drawing.Size(66, 26);
            this.nudEyes.TabIndex = 3;
            // 
            // lblDR
            // 
            this.lblDR.AutoSize = true;
            this.lblDR.Location = new System.Drawing.Point(137, 22);
            this.lblDR.Name = "lblDR";
            this.lblDR.Size = new System.Drawing.Size(35, 20);
            this.lblDR.TabIndex = 4;
            this.lblDR.Text = "DR";
            // 
            // nudSkull
            // 
            this.nudSkull.Location = new System.Drawing.Point(121, 77);
            this.nudSkull.Name = "nudSkull";
            this.nudSkull.Size = new System.Drawing.Size(66, 26);
            this.nudSkull.TabIndex = 5;
            // 
            // nudFace
            // 
            this.nudFace.Location = new System.Drawing.Point(121, 109);
            this.nudFace.Name = "nudFace";
            this.nudFace.Size = new System.Drawing.Size(66, 26);
            this.nudFace.TabIndex = 6;
            // 
            // grbBody
            // 
            this.grbBody.Controls.Add(this.nudGroin);
            this.grbBody.Controls.Add(this.nudNeck);
            this.grbBody.Controls.Add(this.lblBodyDR);
            this.grbBody.Controls.Add(this.nudTorso);
            this.grbBody.Controls.Add(this.cbxGroin);
            this.grbBody.Controls.Add(this.cbxNeck);
            this.grbBody.Controls.Add(this.cbxTorso);
            this.grbBody.Location = new System.Drawing.Point(6, 180);
            this.grbBody.Name = "grbBody";
            this.grbBody.Size = new System.Drawing.Size(193, 149);
            this.grbBody.TabIndex = 1;
            this.grbBody.TabStop = false;
            this.grbBody.Text = "Body";
            // 
            // nudGroin
            // 
            this.nudGroin.Location = new System.Drawing.Point(121, 109);
            this.nudGroin.Name = "nudGroin";
            this.nudGroin.Size = new System.Drawing.Size(66, 26);
            this.nudGroin.TabIndex = 6;
            // 
            // nudNeck
            // 
            this.nudNeck.Location = new System.Drawing.Point(121, 77);
            this.nudNeck.Name = "nudNeck";
            this.nudNeck.Size = new System.Drawing.Size(66, 26);
            this.nudNeck.TabIndex = 5;
            // 
            // lblBodyDR
            // 
            this.lblBodyDR.AutoSize = true;
            this.lblBodyDR.Location = new System.Drawing.Point(137, 22);
            this.lblBodyDR.Name = "lblBodyDR";
            this.lblBodyDR.Size = new System.Drawing.Size(35, 20);
            this.lblBodyDR.TabIndex = 4;
            this.lblBodyDR.Text = "DR";
            // 
            // nudTorso
            // 
            this.nudTorso.Location = new System.Drawing.Point(121, 45);
            this.nudTorso.Name = "nudTorso";
            this.nudTorso.Size = new System.Drawing.Size(66, 26);
            this.nudTorso.TabIndex = 3;
            // 
            // cbxGroin
            // 
            this.cbxGroin.AutoSize = true;
            this.cbxGroin.Location = new System.Drawing.Point(6, 110);
            this.cbxGroin.Name = "cbxGroin";
            this.cbxGroin.Size = new System.Drawing.Size(72, 24);
            this.cbxGroin.TabIndex = 2;
            this.cbxGroin.Text = "Groin";
            this.cbxGroin.UseVisualStyleBackColor = true;
            // 
            // cbxNeck
            // 
            this.cbxNeck.AutoSize = true;
            this.cbxNeck.Location = new System.Drawing.Point(7, 78);
            this.cbxNeck.Name = "cbxNeck";
            this.cbxNeck.Size = new System.Drawing.Size(68, 24);
            this.cbxNeck.TabIndex = 1;
            this.cbxNeck.Text = "Neck";
            this.cbxNeck.UseVisualStyleBackColor = true;
            // 
            // cbxTorso
            // 
            this.cbxTorso.AutoSize = true;
            this.cbxTorso.Location = new System.Drawing.Point(7, 46);
            this.cbxTorso.Name = "cbxTorso";
            this.cbxTorso.Size = new System.Drawing.Size(73, 24);
            this.cbxTorso.TabIndex = 0;
            this.cbxTorso.Text = "Torso";
            this.cbxTorso.UseVisualStyleBackColor = true;
            // 
            // grbLimbs
            // 
            this.grbLimbs.Controls.Add(this.nudLegs);
            this.grbLimbs.Controls.Add(this.label1);
            this.grbLimbs.Controls.Add(this.nudArms);
            this.grbLimbs.Controls.Add(this.cbxLegs);
            this.grbLimbs.Controls.Add(this.cbxArms);
            this.grbLimbs.Location = new System.Drawing.Point(205, 25);
            this.grbLimbs.Name = "grbLimbs";
            this.grbLimbs.Size = new System.Drawing.Size(193, 149);
            this.grbLimbs.TabIndex = 2;
            this.grbLimbs.TabStop = false;
            this.grbLimbs.Text = "Limbs";
            // 
            // nudLegs
            // 
            this.nudLegs.Location = new System.Drawing.Point(121, 77);
            this.nudLegs.Name = "nudLegs";
            this.nudLegs.Size = new System.Drawing.Size(66, 26);
            this.nudLegs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "DR";
            // 
            // nudArms
            // 
            this.nudArms.Location = new System.Drawing.Point(121, 45);
            this.nudArms.Name = "nudArms";
            this.nudArms.Size = new System.Drawing.Size(66, 26);
            this.nudArms.TabIndex = 3;
            // 
            // cbxLegs
            // 
            this.cbxLegs.AutoSize = true;
            this.cbxLegs.Location = new System.Drawing.Point(7, 78);
            this.cbxLegs.Name = "cbxLegs";
            this.cbxLegs.Size = new System.Drawing.Size(67, 24);
            this.cbxLegs.TabIndex = 1;
            this.cbxLegs.Text = "Legs";
            this.cbxLegs.UseVisualStyleBackColor = true;
            // 
            // cbxArms
            // 
            this.cbxArms.AutoSize = true;
            this.cbxArms.Location = new System.Drawing.Point(7, 46);
            this.cbxArms.Name = "cbxArms";
            this.cbxArms.Size = new System.Drawing.Size(69, 24);
            this.cbxArms.TabIndex = 0;
            this.cbxArms.Text = "Arms";
            this.cbxArms.UseVisualStyleBackColor = true;
            // 
            // grbFlexible
            // 
            this.grbFlexible.Controls.Add(this.rdbNo);
            this.grbFlexible.Controls.Add(this.rdbYes);
            this.grbFlexible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFlexible.Location = new System.Drawing.Point(17, 41);
            this.grbFlexible.Name = "grbFlexible";
            this.grbFlexible.Size = new System.Drawing.Size(132, 58);
            this.grbFlexible.TabIndex = 3;
            this.grbFlexible.TabStop = false;
            this.grbFlexible.Text = "Flexible?";
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(8, 25);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(58, 24);
            this.rdbYes.TabIndex = 0;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(72, 25);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(49, 24);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudFeet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudHands);
            this.groupBox1.Controls.Add(this.cbxFeet);
            this.groupBox1.Controls.Add(this.cbxHands);
            this.groupBox1.Location = new System.Drawing.Point(205, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extremities";
            // 
            // nudFeet
            // 
            this.nudFeet.Location = new System.Drawing.Point(121, 77);
            this.nudFeet.Name = "nudFeet";
            this.nudFeet.Size = new System.Drawing.Size(66, 26);
            this.nudFeet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DR";
            // 
            // nudHands
            // 
            this.nudHands.Location = new System.Drawing.Point(121, 45);
            this.nudHands.Name = "nudHands";
            this.nudHands.Size = new System.Drawing.Size(66, 26);
            this.nudHands.TabIndex = 3;
            // 
            // cbxFeet
            // 
            this.cbxFeet.AutoSize = true;
            this.cbxFeet.Location = new System.Drawing.Point(7, 78);
            this.cbxFeet.Name = "cbxFeet";
            this.cbxFeet.Size = new System.Drawing.Size(65, 24);
            this.cbxFeet.TabIndex = 1;
            this.cbxFeet.Text = "Feet";
            this.cbxFeet.UseVisualStyleBackColor = true;
            // 
            // cbxHands
            // 
            this.cbxHands.AutoSize = true;
            this.cbxHands.Location = new System.Drawing.Point(7, 46);
            this.cbxHands.Name = "cbxHands";
            this.cbxHands.Size = new System.Drawing.Size(80, 24);
            this.cbxHands.TabIndex = 0;
            this.cbxHands.Text = "Hands";
            this.cbxHands.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(255, 466);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(77, 53);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(338, 466);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(83, 53);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddArmor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 531);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.grbFlexible);
            this.Controls.Add(this.txtArmorName);
            this.Controls.Add(this.lblArmorName);
            this.Controls.Add(this.grbArmorLocation);
            this.Name = "frmAddArmor";
            this.Text = "Add Armor";
            this.grbArmorLocation.ResumeLayout(false);
            this.grbHead.ResumeLayout(false);
            this.grbHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFace)).EndInit();
            this.grbBody.ResumeLayout(false);
            this.grbBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorso)).EndInit();
            this.grbLimbs.ResumeLayout(false);
            this.grbLimbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArms)).EndInit();
            this.grbFlexible.ResumeLayout(false);
            this.grbFlexible.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArmorLocation;
        private System.Windows.Forms.Label lblArmorName;
        private System.Windows.Forms.TextBox txtArmorName;
        private System.Windows.Forms.GroupBox grbHead;
        private System.Windows.Forms.GroupBox grbBody;
        private System.Windows.Forms.NumericUpDown nudGroin;
        private System.Windows.Forms.NumericUpDown nudNeck;
        private System.Windows.Forms.Label lblBodyDR;
        private System.Windows.Forms.NumericUpDown nudTorso;
        private System.Windows.Forms.CheckBox cbxGroin;
        private System.Windows.Forms.CheckBox cbxNeck;
        private System.Windows.Forms.CheckBox cbxTorso;
        private System.Windows.Forms.NumericUpDown nudFace;
        private System.Windows.Forms.NumericUpDown nudSkull;
        private System.Windows.Forms.Label lblDR;
        private System.Windows.Forms.NumericUpDown nudEyes;
        private System.Windows.Forms.CheckBox cbxFace;
        private System.Windows.Forms.CheckBox cbxSkull;
        private System.Windows.Forms.CheckBox cbxEyes;
        private System.Windows.Forms.GroupBox grbLimbs;
        private System.Windows.Forms.NumericUpDown nudLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudArms;
        private System.Windows.Forms.CheckBox cbxLegs;
        private System.Windows.Forms.CheckBox cbxArms;
        private System.Windows.Forms.GroupBox grbFlexible;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudFeet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHands;
        private System.Windows.Forms.CheckBox cbxFeet;
        private System.Windows.Forms.CheckBox cbxHands;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
    }
}