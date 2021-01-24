namespace textcopier2
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.Generate_Button = new System.Windows.Forms.Button();
            this.SeedNumberTextBox = new System.Windows.Forms.TextBox();
            this.WarpsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShardComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShopComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CrafterComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChestsomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.QuestsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DropsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SavesCountTextBox = new System.Windows.Forms.TextBox();
            this.WarpsCountTextBox = new System.Windows.Forms.TextBox();
            this.LoadsCountTextBox = new System.Windows.Forms.TextBox();
            this.label_savescount = new System.Windows.Forms.Label();
            this.label_warpscount = new System.Windows.Forms.Label();
            this.label_loadscount = new System.Windows.Forms.Label();
            this.spoiler_checkBox = new System.Windows.Forms.CheckBox();
            this.label_savewarpSum = new System.Windows.Forms.Label();
            this.RedHerring_CheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox_OpenOutput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Generate_Button
            // 
            this.Generate_Button.Location = new System.Drawing.Point(331, 378);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(157, 39);
            this.Generate_Button.TabIndex = 0;
            this.Generate_Button.Text = "Generate";
            this.Generate_Button.UseVisualStyleBackColor = true;
            this.Generate_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeedNumberTextBox
            // 
            this.SeedNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedNumberTextBox.Location = new System.Drawing.Point(100, 391);
            this.SeedNumberTextBox.MaxLength = 7;
            this.SeedNumberTextBox.Name = "SeedNumberTextBox";
            this.SeedNumberTextBox.Size = new System.Drawing.Size(166, 26);
            this.SeedNumberTextBox.TabIndex = 1;
            this.SeedNumberTextBox.TabStop = false;
            this.SeedNumberTextBox.TextChanged += new System.EventHandler(this.SeedNumberTextBox_TextChanged);
            this.SeedNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeedNumberTextBox_KeyPress);
            // 
            // WarpsComboBox
            // 
            this.WarpsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarpsComboBox.FormattingEnabled = true;
            this.WarpsComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled",
            "No Logic",
            "Custom (Safe)",
            "Custom (No Logic)"});
            this.WarpsComboBox.Location = new System.Drawing.Point(40, 150);
            this.WarpsComboBox.Name = "WarpsComboBox";
            this.WarpsComboBox.Size = new System.Drawing.Size(175, 21);
            this.WarpsComboBox.TabIndex = 2;
            this.WarpsComboBox.TabStop = false;
            this.WarpsComboBox.SelectedIndexChanged += new System.EventHandler(this.WarpsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save Warps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seed Number (optional)";
            // 
            // ShardComboBox
            // 
            this.ShardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShardComboBox.FormattingEnabled = true;
            this.ShardComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled"});
            this.ShardComboBox.Location = new System.Drawing.Point(300, 50);
            this.ShardComboBox.Name = "ShardComboBox";
            this.ShardComboBox.Size = new System.Drawing.Size(175, 21);
            this.ShardComboBox.TabIndex = 6;
            this.ShardComboBox.TabStop = false;
            this.ShardComboBox.SelectedIndexChanged += new System.EventHandler(this.ShardComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shards";
            // 
            // ShopComboBox
            // 
            this.ShopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopComboBox.FormattingEnabled = true;
            this.ShopComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled"});
            this.ShopComboBox.Location = new System.Drawing.Point(560, 150);
            this.ShopComboBox.Name = "ShopComboBox";
            this.ShopComboBox.Size = new System.Drawing.Size(175, 21);
            this.ShopComboBox.TabIndex = 8;
            this.ShopComboBox.TabStop = false;
            this.ShopComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shop";
            // 
            // CrafterComboBox
            // 
            this.CrafterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrafterComboBox.FormattingEnabled = true;
            this.CrafterComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Random"});
            this.CrafterComboBox.Location = new System.Drawing.Point(560, 50);
            this.CrafterComboBox.Name = "CrafterComboBox";
            this.CrafterComboBox.Size = new System.Drawing.Size(175, 21);
            this.CrafterComboBox.TabIndex = 10;
            this.CrafterComboBox.TabStop = false;
            this.CrafterComboBox.SelectedIndexChanged += new System.EventHandler(this.CrafterComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Crafter";
            // 
            // ChestsomboBox
            // 
            this.ChestsomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChestsomboBox.FormattingEnabled = true;
            this.ChestsomboBox.Items.AddRange(new object[] {
            "Seed17791 Default",
            "Shuffled"});
            this.ChestsomboBox.Location = new System.Drawing.Point(300, 250);
            this.ChestsomboBox.Name = "ChestsomboBox";
            this.ChestsomboBox.Size = new System.Drawing.Size(175, 21);
            this.ChestsomboBox.TabIndex = 12;
            this.ChestsomboBox.TabStop = false;
            this.ChestsomboBox.SelectedIndexChanged += new System.EventHandler(this.ChestsomboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chests";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_label.Location = new System.Drawing.Point(745, 432);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(43, 9);
            this.version_label.TabIndex = 14;
            this.version_label.Text = "Version 0.2";
            // 
            // QuestsComboBox
            // 
            this.QuestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestsComboBox.FormattingEnabled = true;
            this.QuestsComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled"});
            this.QuestsComboBox.Location = new System.Drawing.Point(40, 50);
            this.QuestsComboBox.Name = "QuestsComboBox";
            this.QuestsComboBox.Size = new System.Drawing.Size(175, 21);
            this.QuestsComboBox.TabIndex = 15;
            this.QuestsComboBox.TabStop = false;
            this.QuestsComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestsComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quests";
            // 
            // DropsComboBox
            // 
            this.DropsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropsComboBox.FormattingEnabled = true;
            this.DropsComboBox.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled"});
            this.DropsComboBox.Location = new System.Drawing.Point(300, 150);
            this.DropsComboBox.Name = "DropsComboBox";
            this.DropsComboBox.Size = new System.Drawing.Size(175, 21);
            this.DropsComboBox.TabIndex = 17;
            this.DropsComboBox.TabStop = false;
            this.DropsComboBox.SelectedIndexChanged += new System.EventHandler(this.DropsComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Enemy Drop table";
            // 
            // SavesCountTextBox
            // 
            this.SavesCountTextBox.Enabled = false;
            this.SavesCountTextBox.Location = new System.Drawing.Point(40, 200);
            this.SavesCountTextBox.Name = "SavesCountTextBox";
            this.SavesCountTextBox.Size = new System.Drawing.Size(26, 20);
            this.SavesCountTextBox.TabIndex = 19;
            this.SavesCountTextBox.TextChanged += new System.EventHandler(this.SavesTextBox_TextChanged);
            this.SavesCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SavesTextBox_KeyPress);
            // 
            // WarpsCountTextBox
            // 
            this.WarpsCountTextBox.Enabled = false;
            this.WarpsCountTextBox.Location = new System.Drawing.Point(100, 200);
            this.WarpsCountTextBox.Name = "WarpsCountTextBox";
            this.WarpsCountTextBox.Size = new System.Drawing.Size(26, 20);
            this.WarpsCountTextBox.TabIndex = 20;
            this.WarpsCountTextBox.TextChanged += new System.EventHandler(this.WarpsCountTextBox_TextChanged);
            this.WarpsCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WarpsCountTextBox_KeyPress);
            // 
            // LoadsCountTextBox
            // 
            this.LoadsCountTextBox.Enabled = false;
            this.LoadsCountTextBox.Location = new System.Drawing.Point(160, 200);
            this.LoadsCountTextBox.Name = "LoadsCountTextBox";
            this.LoadsCountTextBox.Size = new System.Drawing.Size(26, 20);
            this.LoadsCountTextBox.TabIndex = 21;
            this.LoadsCountTextBox.TextChanged += new System.EventHandler(this.LoadsCountTextBox_TextChanged);
            this.LoadsCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadsCountTextBox_KeyPress);
            // 
            // label_savescount
            // 
            this.label_savescount.AutoSize = true;
            this.label_savescount.Location = new System.Drawing.Point(37, 184);
            this.label_savescount.Name = "label_savescount";
            this.label_savescount.Size = new System.Drawing.Size(37, 13);
            this.label_savescount.TabIndex = 22;
            this.label_savescount.Text = "Saves";
            // 
            // label_warpscount
            // 
            this.label_warpscount.AutoSize = true;
            this.label_warpscount.Location = new System.Drawing.Point(97, 184);
            this.label_warpscount.Name = "label_warpscount";
            this.label_warpscount.Size = new System.Drawing.Size(38, 13);
            this.label_warpscount.TabIndex = 23;
            this.label_warpscount.Text = "Warps";
            // 
            // label_loadscount
            // 
            this.label_loadscount.AutoSize = true;
            this.label_loadscount.Location = new System.Drawing.Point(157, 184);
            this.label_loadscount.Name = "label_loadscount";
            this.label_loadscount.Size = new System.Drawing.Size(39, 13);
            this.label_loadscount.TabIndex = 24;
            this.label_loadscount.Text = "Blanks";
            // 
            // spoiler_checkBox
            // 
            this.spoiler_checkBox.AutoSize = true;
            this.spoiler_checkBox.Checked = true;
            this.spoiler_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spoiler_checkBox.Location = new System.Drawing.Point(523, 378);
            this.spoiler_checkBox.Name = "spoiler_checkBox";
            this.spoiler_checkBox.Size = new System.Drawing.Size(79, 17);
            this.spoiler_checkBox.TabIndex = 25;
            this.spoiler_checkBox.TabStop = false;
            this.spoiler_checkBox.Text = "Spoiler Log";
            this.spoiler_checkBox.UseVisualStyleBackColor = true;
            this.spoiler_checkBox.CheckStateChanged += new System.EventHandler(this.spoiler_checkBox_CheckStateChanged);
            // 
            // label_savewarpSum
            // 
            this.label_savewarpSum.AutoSize = true;
            this.label_savewarpSum.Enabled = false;
            this.label_savewarpSum.Location = new System.Drawing.Point(209, 203);
            this.label_savewarpSum.Name = "label_savewarpSum";
            this.label_savewarpSum.Size = new System.Drawing.Size(19, 13);
            this.label_savewarpSum.TabIndex = 26;
            this.label_savewarpSum.Text = "39";
            this.label_savewarpSum.Visible = false;
            // 
            // RedHerring_CheckBox
            // 
            this.RedHerring_CheckBox.AutoSize = true;
            this.RedHerring_CheckBox.Location = new System.Drawing.Point(565, 250);
            this.RedHerring_CheckBox.Name = "RedHerring_CheckBox";
            this.RedHerring_CheckBox.Size = new System.Drawing.Size(95, 17);
            this.RedHerring_CheckBox.TabIndex = 27;
            this.RedHerring_CheckBox.TabStop = false;
            this.RedHerring_CheckBox.Text = "Nerfed Charge";
            this.RedHerring_CheckBox.UseVisualStyleBackColor = true;
            this.RedHerring_CheckBox.CheckStateChanged += new System.EventHandler(this.RedHerring_CheckBox_CheckStateChanged);
            // 
            // checkBox_OpenOutput
            // 
            this.checkBox_OpenOutput.AutoSize = true;
            this.checkBox_OpenOutput.Checked = true;
            this.checkBox_OpenOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OpenOutput.Location = new System.Drawing.Point(523, 401);
            this.checkBox_OpenOutput.Name = "checkBox_OpenOutput";
            this.checkBox_OpenOutput.Size = new System.Drawing.Size(178, 17);
            this.checkBox_OpenOutput.TabIndex = 28;
            this.checkBox_OpenOutput.TabStop = false;
            this.checkBox_OpenOutput.Text = "Open Output folder on Generate";
            this.checkBox_OpenOutput.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_OpenOutput);
            this.Controls.Add(this.RedHerring_CheckBox);
            this.Controls.Add(this.label_savewarpSum);
            this.Controls.Add(this.spoiler_checkBox);
            this.Controls.Add(this.label_loadscount);
            this.Controls.Add(this.label_warpscount);
            this.Controls.Add(this.label_savescount);
            this.Controls.Add(this.LoadsCountTextBox);
            this.Controls.Add(this.WarpsCountTextBox);
            this.Controls.Add(this.SavesCountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DropsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuestsComboBox);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChestsomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CrafterComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShopComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShardComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarpsComboBox);
            this.Controls.Add(this.SeedNumberTextBox);
            this.Controls.Add(this.Generate_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Bloodstained Ritual of the Night Enhanced Randomizer";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_Button;
        private System.Windows.Forms.ComboBox WarpsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ShardComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ShopComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CrafterComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ChestsomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.ComboBox QuestsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DropsComboBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox SeedNumberTextBox;
        private System.Windows.Forms.TextBox SavesCountTextBox;
        private System.Windows.Forms.TextBox WarpsCountTextBox;
        private System.Windows.Forms.TextBox LoadsCountTextBox;
        private System.Windows.Forms.Label label_savescount;
        private System.Windows.Forms.Label label_warpscount;
        private System.Windows.Forms.Label label_loadscount;
        private System.Windows.Forms.CheckBox spoiler_checkBox;
        private System.Windows.Forms.Label label_savewarpSum;
        private System.Windows.Forms.CheckBox RedHerring_CheckBox;
        private System.Windows.Forms.CheckBox checkBox_OpenOutput;
    }
}