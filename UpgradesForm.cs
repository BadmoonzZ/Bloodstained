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
    public partial class UpgradesForm : Form
    {
        public UpgradesForm()
        {
            InitializeComponent();
            if (Globals.nerfCharge == true)
            {
                this.NerfedChargeCheckBox.Checked = true;
            }
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

        }

        private void AcceleratorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RandomDebuffCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
