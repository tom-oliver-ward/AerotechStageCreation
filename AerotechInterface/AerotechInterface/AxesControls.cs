using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerotechInterface
{
    public partial class LAxesControlsLaser : Form
    {
        //initialises a variable to access MacroGenerator
        public MacroGenerator macroGenerator; 
        
        protected internal LAxesControlsLaser(MacroGenerator formObject)
        {
            //assigns macroGenerator to the MacroGenerator class
            macroGenerator = formObject;
            InitializeComponent();
        }

        /// <summary>
        /// Feeds back variables into the overall macro list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AxesConfirm_Click(object sender, EventArgs e)
        {
            if (checkBox_X.Checked) { macroGenerator.macroLine[0] = (double)numericUpDownX.Value; }
            if (checkBoxY.Checked == true) { macroGenerator.macroLine[1] = (double)numericUpDownY.Value; }
            if (checkBoxZ.Checked == true) { macroGenerator.macroLine[2] = (double)numericUpDownZ.Value; }
            if (checkBoxLaser.Checked == true) { macroGenerator.macroLine[3] = (double)numericUpDownLaser.Value; }
            macroGenerator.macroLine[4] = (double)numericUpDownRep.Value; 
            if (checkBoxInc.Checked == true) { macroGenerator.macroLine[5] = 0; }
            if (checkBoxAbs.Checked == true) { macroGenerator.macroLine[5] = 1; }
            if (checkBoxGlo.Checked == true) { macroGenerator.macroLine[5] = 2; }

            macroGenerator.macro.Add(macroGenerator.macroLine);
            Array.Clear(macroGenerator.macroLine, 0, macroGenerator.macroLine.Length);            
            this.Close();
        }

        private void checkBoxInc_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAbs.ThreeState = false;
            checkBoxGlo.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }

        private void checkBoxAbs_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxInc.ThreeState = false;
            checkBoxGlo.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }

        private void checkBoxGlo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAbs.ThreeState = false;
            checkBoxInc.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }
    }
}
