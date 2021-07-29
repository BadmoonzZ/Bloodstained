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
    public partial class Enhancements : Form
    {
        public Enhancements()
        {
            InitializeComponent();

            if (Globals.nerfCharge == true)
            {
                this.NerfedChargeCheckBox.Checked = true;
            }
            ToolTip NerfChargeTip = new ToolTip();
            NerfChargeTip.SetToolTip(this.NerfedChargeCheckBox, "Reduces base damage on Hellhound, Aqua Stream, Tis Rozin, Bolide Blast, and VoidRay.");

            if (Globals.earlyAccel == true)
            {
                this.AcceleratorCheckBox.Checked = true;
            }
            ToolTip AccelTip = new ToolTip();
            AccelTip.SetToolTip(this.AcceleratorCheckBox, "Places Accelerator Shard in the first chest.");

            if (Globals.chaosDamage == true)
            {
                this.ChaosDamageCheckBox.Checked = true;
            }
            ToolTip ChaosDmgTip = new ToolTip();
            ChaosDmgTip.SetToolTip(this.ChaosDamageCheckBox, "Drastically increases the damage of 10% of regular enemies.");

            if (Globals.chaosLevel == true)
            {
                this.EnemyLevelCheckbox.Checked = true;
            }
            ToolTip ChaosLevel = new ToolTip();
            ChaosLevel.SetToolTip(this.EnemyLevelCheckbox, "Shuffle the level of all regular enemies.");

            if (Globals.earlyWeapon == true)
            {
                this.WeaponsCheckbox.Checked = true;
            }
            ToolTip WeaponTip = new ToolTip();
            WeaponTip.SetToolTip(this.WeaponsCheckbox, "Places a select random weapon in the first chest.");

            if (Globals.bookcasehints == true)
            {
                this.HintsCheckbox.Checked = true;
            }
            ToolTip HintsTip = new ToolTip();
            HintsTip.SetToolTip(this.HintsCheckbox, "Adds occasionally helpful hints to the bookcases.");

        }

        private void NerfedChargeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NerfedChargeCheckBox.Checked == true)
            {
                Globals.nerfCharge = true;
            }
            else
            {
                Globals.nerfCharge = false;
            }
        }

        private void ChaosDamageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChaosDamageCheckBox.Checked == true)
            {
                Globals.chaosDamage = true;
            }
            else
            {
                Globals.chaosDamage = false;
            }
        }

        private void AcceleratorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AcceleratorCheckBox.Checked == true)
            {
                Globals.earlyAccel = true;
            }
            else
            {
                Globals.earlyAccel = false;
            }
        }

        private void RandomDebuffCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WeaponsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponsCheckbox.Checked == true)
            {
                Globals.earlyWeapon = true;
            }
            else
            {
                Globals.earlyWeapon = false;
            }
        }

        private void EnhancmentsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HintsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (HintsCheckbox.Checked == true)
            {
                Globals.bookcasehints = true;
            }
            else
            {
                Globals.bookcasehints = false;
            }

        }

        private void EnemyLevelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnemyLevelCheckbox.Checked == true)
            {
                Globals.chaosLevel = true;
            }
            else
            {
                Globals.chaosLevel = false;
            }
        }

        private void InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hundredCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MapRandoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
