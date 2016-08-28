namespace GURPSCombatHelper
{
    partial class frmAddEquipment
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
            this.grbWeaponList = new System.Windows.Forms.GroupBox();
            this.grbArmorList = new System.Windows.Forms.GroupBox();
            this.lvwWeapons = new System.Windows.Forms.ListView();
            this.lvwArmor = new System.Windows.Forms.ListView();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.grbWeaponList.SuspendLayout();
            this.grbArmorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbWeaponList
            // 
            this.grbWeaponList.Controls.Add(this.lvwWeapons);
            this.grbWeaponList.Location = new System.Drawing.Point(12, 12);
            this.grbWeaponList.Name = "grbWeaponList";
            this.grbWeaponList.Size = new System.Drawing.Size(545, 188);
            this.grbWeaponList.TabIndex = 0;
            this.grbWeaponList.TabStop = false;
            this.grbWeaponList.Text = "Weapons";
            // 
            // grbArmorList
            // 
            this.grbArmorList.Controls.Add(this.lvwArmor);
            this.grbArmorList.Location = new System.Drawing.Point(12, 206);
            this.grbArmorList.Name = "grbArmorList";
            this.grbArmorList.Size = new System.Drawing.Size(545, 216);
            this.grbArmorList.TabIndex = 1;
            this.grbArmorList.TabStop = false;
            this.grbArmorList.Text = "Armor";
            // 
            // lvwWeapons
            // 
            this.lvwWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWeapons.Location = new System.Drawing.Point(3, 16);
            this.lvwWeapons.Name = "lvwWeapons";
            this.lvwWeapons.Size = new System.Drawing.Size(539, 169);
            this.lvwWeapons.TabIndex = 0;
            this.lvwWeapons.UseCompatibleStateImageBehavior = false;
            // 
            // lvwArmor
            // 
            this.lvwArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwArmor.Location = new System.Drawing.Point(3, 16);
            this.lvwArmor.Name = "lvwArmor";
            this.lvwArmor.Size = new System.Drawing.Size(539, 197);
            this.lvwArmor.TabIndex = 1;
            this.lvwArmor.UseCompatibleStateImageBehavior = false;
            // 
            // cmdOK
            // 
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(365, 425);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(93, 55);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(464, 425);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(93, 55);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 488);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.grbArmorList);
            this.Controls.Add(this.grbWeaponList);
            this.Name = "frmAddEquipment";
            this.Text = "Add Equipment:";
            this.grbWeaponList.ResumeLayout(false);
            this.grbArmorList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbWeaponList;
        private System.Windows.Forms.ListView lvwWeapons;
        private System.Windows.Forms.GroupBox grbArmorList;
        private System.Windows.Forms.ListView lvwArmor;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
    }
}