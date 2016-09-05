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
            this.grbArmorLocation.SuspendLayout();
            this.grbHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFace)).BeginInit();
            this.grbBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorso)).BeginInit();
            this.SuspendLayout();
            // 
            // grbArmorLocation
            // 
            this.grbArmorLocation.Controls.Add(this.grbBody);
            this.grbArmorLocation.Controls.Add(this.grbHead);
            this.grbArmorLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArmorLocation.Location = new System.Drawing.Point(12, 120);
            this.grbArmorLocation.Name = "grbArmorLocation";
            this.grbArmorLocation.Size = new System.Drawing.Size(205, 350);
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
            // frmAddArmor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 482);
            this.Controls.Add(this.txtArmorName);
            this.Controls.Add(this.lblArmorName);
            this.Controls.Add(this.grbArmorLocation);
            this.Name = "frmAddArmor";
            this.Text = "frmAddArmor";
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
    }
}