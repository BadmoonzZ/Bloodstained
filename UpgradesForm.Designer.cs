namespace textcopier2
{
    partial class Enhancements
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
            this.WeaponsCheckbox = new System.Windows.Forms.CheckBox();
            this.EnhancmentsCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NerfedChargeCheckBox
            // 
            this.NerfedChargeCheckBox.AutoSize = true;
            this.NerfedChargeCheckBox.Location = new System.Drawing.Point(12, 43);
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
            this.ChaosDamageCheckBox.Location = new System.Drawing.Point(12, 112);
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
            this.AcceleratorCheckBox.Location = new System.Drawing.Point(12, 66);
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
            this.RandomDebuffCheckBox.Location = new System.Drawing.Point(12, 171);
            this.RandomDebuffCheckBox.Name = "RandomDebuffCheckBox";
            this.RandomDebuffCheckBox.Size = new System.Drawing.Size(106, 17);
            this.RandomDebuffCheckBox.TabIndex = 3;
            this.RandomDebuffCheckBox.Text = "Random Debuffs";
            this.RandomDebuffCheckBox.UseVisualStyleBackColor = true;
            this.RandomDebuffCheckBox.CheckedChanged += new System.EventHandler(this.RandomDebuffCheckBox_CheckedChanged);
            // 
            // WeaponsCheckbox
            // 
            this.WeaponsCheckbox.AutoSize = true;
            this.WeaponsCheckbox.Location = new System.Drawing.Point(12, 89);
            this.WeaponsCheckbox.Name = "WeaponsCheckbox";
            this.WeaponsCheckbox.Size = new System.Drawing.Size(126, 17);
            this.WeaponsCheckbox.TabIndex = 4;
            this.WeaponsCheckbox.Text = "Guaranteed Weapon";
            this.WeaponsCheckbox.UseVisualStyleBackColor = true;
            this.WeaponsCheckbox.CheckedChanged += new System.EventHandler(this.WeaponsCheckbox_CheckedChanged);
            // 
            // EnhancmentsCloseButton
            // 
            this.EnhancmentsCloseButton.Location = new System.Drawing.Point(76, 356);
            this.EnhancmentsCloseButton.Name = "EnhancmentsCloseButton";
            this.EnhancmentsCloseButton.Size = new System.Drawing.Size(75, 23);
            this.EnhancmentsCloseButton.TabIndex = 5;
            this.EnhancmentsCloseButton.Text = "Close";
            this.EnhancmentsCloseButton.UseVisualStyleBackColor = true;
            this.EnhancmentsCloseButton.Click += new System.EventHandler(this.EnhancmentsCloseButton_Click);
            // 
            // Enhancements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 391);
            this.Controls.Add(this.EnhancmentsCloseButton);
            this.Controls.Add(this.WeaponsCheckbox);
            this.Controls.Add(this.RandomDebuffCheckBox);
            this.Controls.Add(this.AcceleratorCheckBox);
            this.Controls.Add(this.ChaosDamageCheckBox);
            this.Controls.Add(this.NerfedChargeCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enhancements";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Enhancements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NerfedChargeCheckBox;
        private System.Windows.Forms.CheckBox ChaosDamageCheckBox;
        private System.Windows.Forms.CheckBox AcceleratorCheckBox;
        private System.Windows.Forms.CheckBox RandomDebuffCheckBox;
        private System.Windows.Forms.CheckBox WeaponsCheckbox;
        private System.Windows.Forms.Button EnhancmentsCloseButton;
    }
}