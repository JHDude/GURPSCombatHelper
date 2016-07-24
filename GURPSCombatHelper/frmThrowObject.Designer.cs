namespace GURPSCombatHelper
{
    partial class frmThrowObject
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
            this.grbThrowObjectParamters = new System.Windows.Forms.GroupBox();
            this.lblST = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.nudST = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.grbThrowObjectParamters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThrowObjectParamters
            // 
            this.grbThrowObjectParamters.Controls.Add(this.nudWeight);
            this.grbThrowObjectParamters.Controls.Add(this.nudST);
            this.grbThrowObjectParamters.Controls.Add(this.lblWeight);
            this.grbThrowObjectParamters.Controls.Add(this.lblST);
            this.grbThrowObjectParamters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThrowObjectParamters.Location = new System.Drawing.Point(12, 31);
            this.grbThrowObjectParamters.Name = "grbThrowObjectParamters";
            this.grbThrowObjectParamters.Size = new System.Drawing.Size(472, 100);
            this.grbThrowObjectParamters.TabIndex = 0;
            this.grbThrowObjectParamters.TabStop = false;
            this.grbThrowObjectParamters.Text = "Parameters";
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(6, 43);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(84, 20);
            this.lblST.TabIndex = 0;
            this.lblST.Text = "Strength:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(245, 43);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(127, 20);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Object Weight:";
            // 
            // nudST
            // 
            this.nudST.Location = new System.Drawing.Point(96, 41);
            this.nudST.Name = "nudST";
            this.nudST.Size = new System.Drawing.Size(60, 26);
            this.nudST.TabIndex = 2;
            this.nudST.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(378, 41);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(60, 26);
            this.nudWeight.TabIndex = 3;
            this.nudWeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(276, 194);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(101, 55);
            this.cmdCalculate.TabIndex = 1;
            this.cmdCalculate.Text = "Calculate!";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(383, 194);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(101, 55);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmThrowObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.grbThrowObjectParamters);
            this.Name = "frmThrowObject";
            this.Text = "Throw Object";
            this.grbThrowObjectParamters.ResumeLayout(false);
            this.grbThrowObjectParamters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThrowObjectParamters;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudST;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClose;
    }
}