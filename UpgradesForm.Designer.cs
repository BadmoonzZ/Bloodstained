namespace textcopier2
{
    partial class UpgradesForm
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
            this.NerfedChargeCheckBox = new System.Windows.Forms.CheckBox();
            this.ChaosDamageCheckBox = new System.Windows.Forms.CheckBox();
            this.AcceleratorCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomDebuffCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NerfedChargeCheckBox
            // 
            this.NerfedChargeCheckBox.AutoSize = true;
            this.NerfedChargeCheckBox.Location = new System.Drawing.Point(12, 71);
            this.NerfedChargeCheckBox.Name = "NerfedChargeCheckBox";
            this.NerfedChargeCheckBox.Size = new System.Drawing.Size(95, 17);
            this.NerfedChargeCheckBox.TabIndex = 0;
            this.NerfedChargeCheckBox.Text = "Nerfed Charge";
            this.NerfedChargeCheckBox.UseVisualStyleBackColor = true;
            this.NerfedChargeCheckBox.CheckedChanged += new System.EventHandler(this.NerfedChargeCheckBox_CheckedChanged);
            // 
            // ChaosDamageCheckBox
            // 
            this.ChaosDamageCheckBox.AutoSize = true;
            this.ChaosDamageCheckBox.Enabled = false;
            this.ChaosDamageCheckBox.Location = new System.Drawing.Point(12, 94);
            this.ChaosDamageCheckBox.Name = "ChaosDamageCheckBox";
            this.ChaosDamageCheckBox.Size = new System.Drawing.Size(99, 17);
            this.ChaosDamageCheckBox.TabIndex = 1;
            this.ChaosDamageCheckBox.Text = "Chaos Damage";
            this.ChaosDamageCheckBox.UseVisualStyleBackColor = true;
            this.ChaosDamageCheckBox.CheckedChanged += new System.EventHandler(this.ChaosDamageCheckBox_CheckedChanged);
            // 
            // AcceleratorCheckBox
            // 
            this.AcceleratorCheckBox.AutoSize = true;
            this.AcceleratorCheckBox.Enabled = false;
            this.AcceleratorCheckBox.Location = new System.Drawing.Point(13, 118);
            this.AcceleratorCheckBox.Name = "AcceleratorCheckBox";
            this.AcceleratorCheckBox.Size = new System.Drawing.Size(139, 17);
            this.AcceleratorCheckBox.TabIndex = 2;
            this.AcceleratorCheckBox.Text = "Guaranteed Accelerator";
            this.AcceleratorCheckBox.UseVisualStyleBackColor = true;
            this.AcceleratorCheckBox.CheckedChanged += new System.EventHandler(this.AcceleratorCheckBox_CheckedChanged);
            // 
            // RandomDebuffCheckBox
            // 
            this.RandomDebuffCheckBox.AutoSize = true;
            this.RandomDebuffCheckBox.Enabled = false;
            this.RandomDebuffCheckBox.Location = new System.Drawing.Point(13, 141);
            this.RandomDebuffCheckBox.Name = "RandomDebuffCheckBox";
            this.RandomDebuffCheckBox.Size = new System.Drawing.Size(106, 17);
            this.RandomDebuffCheckBox.TabIndex = 3;
            this.RandomDebuffCheckBox.Text = "Random Debuffs";
            this.RandomDebuffCheckBox.UseVisualStyleBackColor = true;
            this.RandomDebuffCheckBox.CheckedChanged += new System.EventHandler(this.RandomDebuffCheckBox_CheckedChanged);
            // 
            // UpgradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 391);
            this.Controls.Add(this.RandomDebuffCheckBox);
            this.Controls.Add(this.AcceleratorCheckBox);
            this.Controls.Add(this.ChaosDamageCheckBox);
            this.Controls.Add(this.NerfedChargeCheckBox);
            this.Name = "UpgradesForm";
            this.Text = "UpgradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NerfedChargeCheckBox;
        private System.Windows.Forms.CheckBox ChaosDamageCheckBox;
        private System.Windows.Forms.CheckBox AcceleratorCheckBox;
        private System.Windows.Forms.CheckBox RandomDebuffCheckBox;
    }
}