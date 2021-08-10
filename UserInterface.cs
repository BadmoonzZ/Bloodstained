using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textcopier2
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();

        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            WarpsComboBox.SelectedIndex = 1;
            ChestsomboBox.SelectedIndex = 1;
            ShardComboBox.SelectedIndex = 1;
            ShopComboBox.SelectedIndex = 1;
            CrafterComboBox.SelectedIndex = 1;
            QuestsComboBox.SelectedIndex = 1;
            DropsComboBox.SelectedIndex = 1;

            SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
            WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
            LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
        }

        //Generate Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveWarp.roomssavecount + SaveWarp.roomswarpcount + SaveWarp.roomsloadcount != 39 && SaveWarp.modeselection == 3)
            {
                MessageBox.Show("Save Warps has invalid amount. Total must = 39");
            }
            else if (SaveWarp.roomssavecount + SaveWarp.roomswarpcount + SaveWarp.roomsloadcount != 44 && SaveWarp.modeselection == 4)
            {
                MessageBox.Show("Save Warps has invalid amount.  Total must = 44");
            }
            else
            {
                Generate.CreateSeed();
                Globals.seednumber = 0;
                SeedNumberTextBox.Text = "0";
                if (checkBox_OpenOutput.Checked == true)
                {
                    new System.IO.FileInfo("Output\\file.txt").Directory.Create();  //this creates the directories if they don't exist.
                    System.Diagnostics.Process.Start("Output");
                }
            }
        }

        private void SeedNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int thevalue;
            if (int.TryParse(SeedNumberTextBox.Text, out thevalue)) ;
            else thevalue = 0;

            Globals.seednumber = thevalue;
        }

        private void SeedNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Combo box settings
        private void ShardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShardComboBox.SelectedIndex == 0)
            {
                Globals.shuffleShardsOn = false;
            }
            else if (ShardComboBox.SelectedIndex == 1)
            {
                Globals.shuffleShardsOn = true;
            }
        }

        private void CrafterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CrafterComboBox.SelectedIndex == 0)
            {
                Globals.shuffleCraftOn = false;
            }
            else if (CrafterComboBox.SelectedIndex == 1)
            {
                Globals.shuffleCraftOn = true;
            }
        }

        private void DropsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropsComboBox.SelectedIndex == 0)
            {
                Globals.shuffleDropsOn = false;
            }
            else if (DropsComboBox.SelectedIndex == 1)
            {
                Globals.shuffleDropsOn = true;
            }
        }

        private void ChestsomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChestsomboBox.SelectedIndex == 0)
            {
                Globals.shuffleChestOn = false;
            }
            else if (ChestsomboBox.SelectedIndex == 1)
            {
                Globals.shuffleChestOn = true;
            }
        }


        private void ShopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShopComboBox.SelectedIndex == 0)
            {
                Globals.shuffleShopOn = false;
            }
            else if (ShopComboBox.SelectedIndex == 1)
            {
                Globals.shuffleShopOn = true;
            }
        }

        private void QuestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestsComboBox.SelectedIndex == 0)
            {
                Globals.shuffleQuestsOn = false;
            }
            else if (QuestsComboBox.SelectedIndex == 1)
            {
                Globals.shuffleQuestsOn = true;
            }
        }


        private void WarpsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = WarpsComboBox.SelectedIndex;
            switch (selectedindex)
            {
                case 0: //vanilla
                    Globals.shullfeSaveWarpOn = false;
                    SaveWarp.modeselection = 0;
                    label_savewarpSum.Enabled = false;

                    SaveWarp.roomssavecount = 26;
                    SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
                    SavesCountTextBox.Enabled = false;
                    SaveWarp.roomswarpcount = 13;
                    WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
                    WarpsCountTextBox.Enabled = false;
                    SaveWarp.roomsloadcount = 0;
                    LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
                    LoadsCountTextBox.Enabled = false;
                    break;
                case 1:  //shuffle
                    Globals.shullfeSaveWarpOn = true;
                    SaveWarp.modeselection = 1;
                    label_savewarpSum.Enabled = false;

                    SaveWarp.roomssavecount = 26;
                    SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
                    SavesCountTextBox.Enabled = false;
                    SaveWarp.roomswarpcount = 13;
                    WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
                    WarpsCountTextBox.Enabled = false;
                    SaveWarp.roomsloadcount = 0;
                    LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
                    LoadsCountTextBox.Enabled = false;
                    break;
                case 2:  //no logic
                    Globals.shullfeSaveWarpOn = true;
                    SaveWarp.modeselection = 2;
                    label_savewarpSum.Enabled = false;

                    SaveWarp.roomssavecount = 28;
                    SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
                    SavesCountTextBox.Enabled = false;
                    SaveWarp.roomswarpcount = 16;
                    WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
                    WarpsCountTextBox.Enabled = false;
                    SaveWarp.roomsloadcount = 0;
                    LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
                    LoadsCountTextBox.Enabled = false;
                    break;
                case 3:  //custom
                    Globals.shullfeSaveWarpOn = true;
                    SaveWarp.modeselection = 3;
                    label_savewarpSum.Enabled = true;

                    SaveWarp.roomssavecount = 26;
                    SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
                    SavesCountTextBox.Enabled = true;
                    SaveWarp.roomswarpcount = 13;
                    WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
                    WarpsCountTextBox.Enabled = true;
                    SaveWarp.roomsloadcount = 0;
                    LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
                    LoadsCountTextBox.Enabled = true;
                    break;
                case 4:  //custom no logic
                    Globals.shullfeSaveWarpOn = true;
                    SaveWarp.modeselection = 4;
                    label_savewarpSum.Enabled = true;

                    SaveWarp.roomssavecount = 28;
                    SavesCountTextBox.Text = SaveWarp.roomssavecount.ToString();
                    SavesCountTextBox.Enabled = true;
                    SaveWarp.roomswarpcount = 16;
                    WarpsCountTextBox.Text = SaveWarp.roomswarpcount.ToString();
                    WarpsCountTextBox.Enabled = true;
                    SaveWarp.roomsloadcount = 0;
                    LoadsCountTextBox.Text = SaveWarp.roomsloadcount.ToString();
                    LoadsCountTextBox.Enabled = true;
                    break;
            }
        }

        private void SavesTextBox_TextChanged(object sender, EventArgs e)
        {
            int thevalue;
            if (int.TryParse(SavesCountTextBox.Text, out thevalue)) ;
            else thevalue = 0;

            if (thevalue >= 39)
            {
                thevalue = 39;
            }
            SavesCountTextBox.Text = thevalue.ToString();
            SaveWarp.roomssavecount = thevalue;

        }
        private void SavesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;


            }
        }

        private void WarpsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            int thevalue;
            if (int.TryParse(WarpsCountTextBox.Text, out thevalue)) ;
            else thevalue = 0;

            if (thevalue >= 39)
            {
                thevalue = 39;
            }
            WarpsCountTextBox.Text = thevalue.ToString();
            SaveWarp.roomswarpcount = thevalue;

        }
        private void WarpsCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            int thevalue;
            if (int.TryParse(LoadsCountTextBox.Text, out thevalue)) ;
            else thevalue = 0;

            if (thevalue >= 39)
            {
                thevalue = 39;
            }
            LoadsCountTextBox.Text = thevalue.ToString();
            SaveWarp.roomsloadcount = thevalue;
        }
        private void LoadsCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //spoiler
        private void spoiler_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (spoiler_checkBox.Checked == true)
            {
                Globals.writeSpoilerLog = true;
            }
            else
            {
                Globals.writeSpoilerLog = false;

            }
        }


        private void EnhanceFormButton_Click(object sender, EventArgs e)
        {
            Enhancements child = new Enhancements();
            child.ShowDialog();
        }

        private void TournamentcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TournamentcheckBox1.Checked == true)
            {
                Globals.tournyseed = true;

                //now enforce settings:

                spoiler_checkBox.Enabled = false;
                spoiler_checkBox.Checked = false;
                Globals.writeSpoilerLog = false;


                QuestsComboBox.SelectedIndex = 1;
                Globals.shuffleQuestsOn = true;
                QuestsComboBox.Enabled = false;

                WarpsComboBox.SelectedIndex = 1;
                Globals.shullfeSaveWarpOn = true;
                SaveWarp.modeselection = 1;
                WarpsComboBox.Enabled = false;  //may be extra things to check for this to reset properly

                ShardComboBox.SelectedIndex = 1;
                Globals.shuffleShardsOn = true;
                ShardComboBox.Enabled = false;

                CrafterComboBox.SelectedIndex = 1;
                Globals.shuffleCraftOn = true;
                CrafterComboBox.Enabled = false;

                ShopComboBox.SelectedIndex = 1;
                Globals.shuffleShopOn = true;
                ShopComboBox.Enabled = false;

                DropsComboBox.SelectedIndex = 1;
                Globals.shuffleDropsOn = true;
                DropsComboBox.Enabled = false;

                ChestsomboBox.SelectedIndex = 1;
                Globals.shuffleChestOn = true;
                ChestsomboBox.Enabled = false;

                //seed
                SeedNumberTextBox.Enabled = false;
                Globals.seednumber = 0; //this should ignore any previous input.

                EnhanceFormButton.Enabled = false;
                Globals.earlyAccel = true;
                Globals.earlyWeapon = true;
                Globals.bookcasehints = true;  //TBD

                Globals.chaosDamage = false;  //this will not uncheck boxes, but will unset them.
                Globals.chaosLevel = false;
                Globals.nerfCharge = false;

            }
            else
            {
                Globals.tournyseed = false;

                spoiler_checkBox.Enabled = true;

                QuestsComboBox.Enabled = true;
                WarpsComboBox.Enabled = true;
                ShardComboBox.Enabled = true;
                CrafterComboBox.Enabled = true;
                ShopComboBox.Enabled = true;
                DropsComboBox.Enabled = true;
                ChestsomboBox.Enabled = true;

                SeedNumberTextBox.Enabled = true;

                EnhanceFormButton.Enabled = true;

            }
        }
    }
}
